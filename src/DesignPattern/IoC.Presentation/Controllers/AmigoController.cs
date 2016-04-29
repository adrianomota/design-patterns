using FastMapper;
using IoC.Business;
using IoC.DataTransferObject;
using IoC.Presentation.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace IoC.Presentation.Controllers
{
    public sealed class AmigoController : Controller
    {
        private readonly AmigoBusiness _amigoBusiness;

        public AmigoController(AmigoBusiness amigoBusiness)
        {
            _amigoBusiness = amigoBusiness;
        }

        [HttpGet]
        public ViewResult Listar()
        {
            var amigos = _amigoBusiness.Listar();
            var amigosViewModel = TypeAdapter.Adapt<IEnumerable<AmigoDTO>, IEnumerable<AmigoViewModel>>(amigos);
            return View(amigosViewModel);
        }

        [HttpGet]
        public ViewResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult Cadastrar(AmigoViewModel model)
        {
            var amigo = TypeAdapter.Adapt<AmigoViewModel, AmigoDTO>(model);
            
            _amigoBusiness.Cadastrar(amigo);

            return RedirectToAction("Listar");
        }
    }
}