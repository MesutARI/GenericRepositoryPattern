using AutoMapper;
using GenericRepository.API.DTO;
using GenericRepository.Core.Models;
using GenericRepository.Core.UnitOfWorks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericRepository.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        #region variables

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion

        #region CategoriesController
        public CategoriesController(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            this._unitOfWork = _unitOfWork;
            this._mapper = _mapper;
        }
        #endregion

        #region Methods

        #region GetAll

        // GET api/categories
        [HttpGet]
        public ActionResult GetAll()
        {
            //  var model = _unitOfWork.CategoryRepository.GetAll();
            //    return Ok(model);
            var model = _unitOfWork.CategoryServices.GetAll();
            if (model.Success)
            {
                var modelResources = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(model.Contents);
                return Ok(modelResources);
                //return Ok(model.Contents);
            }
            else if (model.StatusCode == System.Net.HttpStatusCode.NoContent)
                return NoContent();
            else
                return BadRequest(model.Message);
            
        }

        // api/categories/GetAllAsync
        [HttpGet]
        [Route("GetAllAsync")]
        public async Task<ActionResult> GetAllAsync()
        {
            var model = await _unitOfWork.CategoryServices.GetAllAsync();
            if (model.Success)
                return Ok(model.Contents);
            else if (model.StatusCode == System.Net.HttpStatusCode.NoContent)
                return NoContent();
            else
                return BadRequest(model.Message);
        }
        
        #endregion

        #region GetById
        
        // api/categories/GetById/2
        [HttpGet("GetById/{Id}")]
        public ActionResult GetById(int Id)
        {
            
            var model = _unitOfWork.CategoryServices.GetById(Id);
            if (model.Success)
                return Ok(model.Contents);
            else if (model.StatusCode == System.Net.HttpStatusCode.NoContent)
                return NoContent();
            else
                return BadRequest(model.Message);
        }

        // api/categories/GetByIdAsync?Id=2
        [HttpGet("GetbyIdAsync/{Id}")]
        public async Task<ActionResult> GetbyIdAsync(int Id)
        {
            var model = await _unitOfWork.CategoryServices.GetByIdAsync(Id);
            if (model.Success)
                return Ok(model.Contents);
            //return await Task.FromResult(Ok(model.Tables));
            else
                return BadRequest(model.Message);

        }

        #endregion

        #region Add
        
        // api/categories/Add
        [HttpPost]
        [Route("Add")]
        public ActionResult Add(Category category)
        {
            var model = _unitOfWork.CategoryServices.Add(category);

            if (model.Success)
            {
                this._unitOfWork.Complete();
                return Ok(model.Contents);
            }
            else
                return BadRequest(model.Message);

        }

        // api/categories/AddAsync
        [HttpPost]
        [Route("AddAsync")]
        public async Task<ActionResult> AddAsync(Category category)
        {
            // Validation

            //CategoryDTO _categoryDto = _mapper.Map<Category, CategoryDTO>(category);

            //var validator = new CategoriesValidator();
            //var validationResult = await validator.ValidateAsync(_categoryDto);

            //if (!validationResult.IsValid)
            //    return BadRequest(validationResult.Errors);


            var model = await _unitOfWork.CategoryServices.AddAsync(category);

            if (model.Success)
            {
                await _unitOfWork.CompleteAsync();
                return Ok(model.Contents);
            }
            else
                return BadRequest(model.Message);

        }

        #endregion

        #region Update
        // api/categories/Update/11
        [HttpPut("Update/{Id}")]
        //[HttpPut]
        [Route("Update")]
        public ActionResult Update(Category category, int Id)
        {
            if (Id != category.CategoryId)
                return BadRequest();

            var model = _unitOfWork.CategoryServices.Update(category);

            if (model.Success)
            {
                this._unitOfWork.Complete();
                return Ok(model.Contents);
            }
            else
                return BadRequest(model.Message);

        }

        // api/categories/AddAsync/11
        [HttpPut("UpdateAsync/{Id}")]
        [Route("UpdateAsync")]
        public async Task<ActionResult> UpdateAsync(Category category, int Id)
        {
            if (Id != category.CategoryId)
                return BadRequest();

            var model = await _unitOfWork.CategoryServices.UpdateAsync(category);

            if (model.Success)
            {
                await this._unitOfWork.CompleteAsync();
                return Ok(model.Contents);
            }
            else
                return BadRequest(model.Message);

        }

        #endregion

        #region Delete
        // api/categories/Delete/1
        [HttpDelete("Delete/{Id}")]
        [Route("Delete")]
        public ActionResult Delete(int Id)
        {
            var deletingModel = _unitOfWork.CategoryServices.GetById(Id);
            if (deletingModel.Success)
            {
                var deletedModel = _unitOfWork.CategoryServices.Delete(deletingModel.Contents.CategoryId);

                if (deletedModel.Success)
                {
                    this._unitOfWork.Complete();
                    return Ok(deletingModel.Contents);
                }

                else
                    return BadRequest(deletedModel.Message);
                

            }
            else if (deletingModel.StatusCode == System.Net.HttpStatusCode.NoContent)
                return NoContent();
            else
                return BadRequest(deletingModel.Message);

        }

        // api/categories/Delete/1
        [HttpDelete("DeleteAsync/{Id}")]
        [Route("DeleteAsync")]
        public async Task<ActionResult> DeleteAsync(int Id)
        {
            var deletingModel = await _unitOfWork.CategoryServices.GetByIdAsync(Id);
            if (deletingModel.Success)
            {
                var deletedModel = await _unitOfWork.CategoryServices.DeleteAsync(deletingModel.Contents.CategoryId);

                if (deletedModel.Success)
                {
                    await this._unitOfWork.CompleteAsync();
                    return Ok(deletingModel.Contents);
                }
                else if (deletedModel.Message.Contains("Fail::"))
                    return NotFound(deletedModel.Message);
                else
                    return BadRequest(deletedModel.Message);

            }
            else if (deletingModel.StatusCode == System.Net.HttpStatusCode.NoContent)
                return NoContent();
            else
                return BadRequest(deletingModel.Message);

        }

        #endregion

        #endregion

    }
}
