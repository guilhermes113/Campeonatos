using Microsoft.AspNetCore.Mvc;
using Campeonatos.Data;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Campeonatos.Models.ViewModels.Responsive;
using Campeonatos.Models.ViewModels.Request;
using Campeonatos.Models;

namespace Campeonatos.Controllers
{
    public class UsersController : Controller
    {
        
        private Camp _dbcamp;

        public UsersController(Camp camp) 
        {
            _dbcamp = camp;
        }
       
        public IActionResult Index()
        {
            return View(_dbcamp.Users);
        }
        public IActionResult Detalhes(int id)
        {
            #region Método 1
            var resultado = _dbcamp.Users.Include(tu => tu.TimesUsers)
                                        .ThenInclude(t => t.Time)
                                        .FirstOrDefault(user => user.Id == id);
            if (resultado == null)
                View();
            GetUserView atorDTO = new GetUserView()
            {
                Nome = resultado.Name
            };
            return View(resultado);
            #endregion
            #region Método 2
            //var result = _context.Atores.Where(ator => ator.Id == id).Select(at => new GetAtoresDTO()
            //{
            //Bio = at.Bio,
            //FotoPerfilURL = at.FotoPerfilURL,
            //Nome = at.Nome,
            //NomeFilmes = at.AtoresFilmes.Select(fm => fm.Filme.Titulo).ToList(),
            //FotoURLFilmes = at.AtoresFilmes.Select(fm => fm.Filme.ImagemURL).ToList()
            //}).FirstOrDefault();

            #endregion
        }


        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar([Bind("Name,Email,Number")] PostUserView userDTO)
        {
            if (!ModelState.IsValid) return View(userDTO);
            User user = new User(userDTO.Name, userDTO.Email , userDTO.Number);
            _dbcamp.Users.Add(user);
            _dbcamp.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Deletar(int id)
        {
            var result = _dbcamp.Users.FirstOrDefault(u => u.Id == id);
            if (result == null) return View();

            return View(result);
        }
        [HttpPost, ActionName("Deletar")]
        public IActionResult ConfirmarDeletar(int id)
        {
            var result = _dbcamp.Users.FirstOrDefault(u => u.Id == id);
            _dbcamp.Users.Remove(result);
            _dbcamp.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Atualizar(int? id)
        {
            if (id == null)
                return NotFound();
            var result = _dbcamp.Users.FirstOrDefault(p => p.Id == id);

            if (result == null)
                return View("NotFound");

            return View(result);
        }

        [HttpPost]
        public IActionResult Atualizar(int id, PostUserView userDTO)
        {
            var user = _dbcamp.Users.FirstOrDefault(p => p.Id == id);

            if (!ModelState.IsValid)
                return View();

            user.AtualizarDados(userDTO.Name, userDTO.Email, userDTO.Number);

            _dbcamp.Update(user);
            _dbcamp.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Busca(string filtro)
        {
            var resultado = _dbcamp.Users.ToList();

            if (!string.IsNullOrEmpty(filtro))
            {
                filtro = filtro.ToLower();
                var re = resultado.Where(x => x.Name.ToLower().Contains(filtro) || x.Email.ToLower().Contains(filtro)).ToList();
                return View(nameof(Index), re);
            };
            return View(nameof(Index), resultado);
        }

    }
}
