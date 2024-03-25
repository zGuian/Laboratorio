using AutoMapper;
using EFTS_Application.DTOs;
using EFTS_Application.Filters;
using EFTS_Application.Interfaces;
using EFTS_Domain.Enums;
using EFTS_WebUI.Models.LaboratorioModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EFTS_WebUI.Controllers
{
    [Route("laboratorio")]
    [PagUsuarioLogado]
    public class LaboratorioController : Controller
    {
        private readonly ILaboratorioServices _services;
        private readonly IMapper _mapper;

        public LaboratorioController(ILaboratorioServices services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }

        [Route("equipamentos")]
        public async Task<IActionResult> Index()
        {
            var labDTO = await _services.BuscaEquipAsync();
            var model = labDTO.Select(equipDTO => new LaboratorioModel
            {
                Id = equipDTO.Id,
                TipoEquipamento = equipDTO.TipoEquipamento,
                SerialNumber = equipDTO.SerialNumber,
                Inventario = equipDTO.Inventario,
                Cadeado = equipDTO.Cadeado,
                TipoEquipOptions = new SelectList(equipDTO.TipoEquipamento.ToString()),
                ArmarioOptions = new SelectList(equipDTO.Armario.ToString())
            });
            return View(model);
        }

        [Route("cadastro")]
        public IActionResult CadastroEquipamento()
        {
            var enumValuesEquip = Enum.GetValues(typeof(EnumTipoEquipamento)).Cast<EnumTipoEquipamento>();
            var enumValuesArmario = Enum.GetValues(typeof(EnumArmario)).Cast<EnumArmario>();
            var model = new LaboratorioModel
            {
                ArmarioOptions = new SelectList(enumValuesArmario.Select(value => new SelectListItem
                {
                    Text = Enum.GetName(typeof(EnumArmario), value),
                    Value = value.ToString(),
                }), "Value", "Text"),
                TipoEquipOptions = new SelectList(enumValuesEquip.Select(value => new SelectListItem
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
        public IActionResult CadastroEquipamento(LaboratorioModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Mensagem", "Ocorreu um erro");
                return View();
            }
            var labDTO = _mapper.Map<LaboratorioDTO>(model);
            _services.CadastraEquipamento(labDTO);
            return RedirectToAction(nameof(Index));
        }

        [Route("editar")]
        public async Task<IActionResult> EditarEquipamento(int id)
        {
            var labDTO = await _services.BuscaEquipAsync();
            var enumValuesEquip = Enum.GetValues(typeof(EnumTipoEquipamento)).Cast<EnumTipoEquipamento>();
            var enumValuesArmario = Enum.GetValues(typeof(EnumArmario)).Cast<EnumArmario>();
            var model = labDTO.Select(labDTO => new LaboratorioModel
            {
                Id = labDTO.Id,
                TipoEquipamento = labDTO.TipoEquipamento,
                SerialNumber = labDTO.SerialNumber,
                Inventario = labDTO.Inventario,
                Cadeado = labDTO.Cadeado,
                ArmarioOptions = new SelectList(enumValuesArmario.Select(value => new SelectListItem
                {
                    Text = Enum.GetName(typeof(EnumArmario), value),
                    Value = value.ToString(),
                    Selected = value == labDTO.Armario
                }), "Value", "Text", labDTO.Armario),
                TipoEquipOptions = new SelectList(enumValuesEquip.Select(value => new SelectListItem
                {
                    Text = Enum.GetName(typeof(EnumTipoEquipamento), value),
                    Value = value.ToString(),
                    Selected = value == labDTO.TipoEquipamento
                }), "Value", "Text", labDTO.TipoEquipamento)
            });
            return View(model);
        }

        [HttpPost]
        [Route("editar")]
        [ValidateAntiForgeryToken]
        public IActionResult EditarEquipamento(int id, LaboratorioModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Mensagem", "Ocorreu um erro");
                return View();
            }
            var labDTO = _mapper.Map<LaboratorioDTO>(model);
            _services.AtualizaEquipamento(id, labDTO);
            return RedirectToAction(nameof(Index));
        }
    }
}