using AutoMapper;
using Lab_Application.DTOs;
using Lab_Application.Interfaces;
using Lab_Domain.Enums;
using Lab_WebUI.Models.EquipamentosModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab_WebUI.Controllers
{
    [Route("equipamento")]
    public class EquipamentoController : Controller
    {
        private readonly IEquipamentoServices _services;
        private readonly IMapper _mapper;

        public EquipamentoController(IEquipamentoServices services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }

        [Route("lista")]
        public async Task<IActionResult> Index()
        {
            var equipDTO = await _services.BuscaEquipAsync();
            var model = equipDTO.Select(equipDTO => new EquipamentoModel
            {
                Id = equipDTO.Id,
                TipoEquipamento = equipDTO.TipoEquipamento,
                SerialNumber = equipDTO.SerialNumber,
                Inventario = equipDTO.Inventario,
                Cadeado = equipDTO.Cadeado,
                TipoEquipOptions = new SelectList(equipDTO.TipoEquipamento.ToString())
            }).ToList();
            return View(model);
        }

        [Route("cadastro")]
        public IActionResult CadastroEquipamento()
        {
            var enumValues = Enum.GetValues(typeof(EnumTipoEquipamento)).Cast<EnumTipoEquipamento>();

            var model = new EquipamentoModel
            {
                TipoEquipOptions = new SelectList(enumValues.Select(value => new SelectListItem
                {
                    Text = Enum.GetName(typeof(EnumTipoEquipamento), value),
                    Value = value.ToString(),
                }), "Value", "Text")
            };
            return View(model);
        }

        [HttpPost]
        [Route("cadastro")]
        [ValidateAntiForgeryToken]
        public IActionResult CadastroEquipamento(EquipamentoModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Mensagem", "Ocorreu um erro");
                return View();
            }
            var equipDTO = _mapper.Map<EquipamentoDTO>(model);
            _services.CadastraEquipamento(equipDTO);
            return RedirectToAction(nameof(Index));
        }

        [Route("editar")]
        public async Task<IActionResult> EditarEquipamento(int id)
        {
            var equipDTO = await _services.BuscaEquipAsync();
            var enumValues = Enum.GetValues(typeof(EnumTipoEquipamento)).Cast<EnumTipoEquipamento>();
            var model = equipDTO.Select(equipDTO => new EquipamentoModel
            {
                Id = equipDTO.Id,
                TipoEquipamento = equipDTO.TipoEquipamento,
                SerialNumber = equipDTO.SerialNumber,
                Inventario = equipDTO.Inventario,
                Cadeado = equipDTO.Cadeado,
                TipoEquipOptions = new SelectList(enumValues.Select(value => new SelectListItem
                {
                    Text = Enum.GetName(typeof(EnumTipoEquipamento), value),
                    Value = value.ToString(),
                    Selected = value == equipDTO.TipoEquipamento
                }), "Value", "Text", equipDTO.TipoEquipamento)
            }).ToList();
            return View(model);
        }

        [HttpPost]
        [Route("editar")]
        [ValidateAntiForgeryToken]
        public IActionResult EditarEquipamento(int id, EquipamentoModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Mensagem", "Ocorreu um erro");
                return View();
            }
            var equipDTO = _mapper.Map<EquipamentoDTO>(model);
            _services.AtualizaEquipamento(id, equipDTO);
            return RedirectToAction(nameof(Index));
        }
    }
}
