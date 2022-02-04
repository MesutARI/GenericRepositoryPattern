using GenericRepository.Core.Models;
using GenericRepository.Core.Repositories;
using GenericRepository.DataAccess.Contexts;
using GenericRepository.DataAccess.Repositories;
using GenericRepository.Service.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Xunit;

namespace GenericRepository.Tests
{
    public class CategoryServiceTests
    {
        #region variables
        private readonly NorthwindContext _context = new NorthwindContext();

        private readonly CategoryService _categoryServiceMock;
        private readonly Mock<ICategoryRepository> mock = new Mock<ICategoryRepository>();
        
        private readonly CategoryService _categoryService;
        private readonly ICategoryRepository _categoryRepository;
        #endregion

        #region CategoryServiceTests
        public CategoryServiceTests()
        {
            _categoryServiceMock = new CategoryService(mock.Object);
            
            _categoryRepository = new CategoryRepository(_context);
            _categoryService = new CategoryService(_categoryRepository);
        }
        #endregion

        #region Methods

        #region GetById
        [Fact]
        public void GetById_ShouldReturnCategory_WhenCategoryExist()
        {
            // Arrange
            var _categoryId = 3;
            var _categoryName = "Confections";

            // Act
            var _expected = _categoryService.GetById(_categoryId);

            // Assert
            Assert.Equal(_categoryId, _expected.Contents.CategoryId);
            Assert.Equal(_categoryName, _expected.Contents.CategoryName);
        }
        
        [Fact]
        public void GetById_ShouldReturnNull_WhenCategoryDoesNotExist()
        {
            // Arrange
            var categoryId = 34;

            // Act
            var _expected = _categoryService.GetById(categoryId);

            // Assert
            Assert.Null(_expected.Contents);

        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnCategory_WhenCategoryExist()
        {
            // Arrange
            var _categoryId = 3;
            var _categoryName = "Confections";

            // Act
            var _expected = await _categoryService.GetByIdAsync(_categoryId);

            // Assert
            Assert.Equal(_categoryId, _expected.Contents.CategoryId);
            Assert.Equal(_categoryName, _expected.Contents.CategoryName);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldReturnNull_WhenCategoryDoesNotExist()
        {
            // Arrange
            var categoryId = 34;

            // Act
            var _expected = await _categoryService.GetByIdAsync(categoryId);

            // Assert
            Assert.Null(_expected.Contents);

        }


        [Fact]
        public void GetById_ShouldReturnCategory_WhenCategoryExist_WithMock()
        {
            // Arrange
            var _categoryId = 3;
            var _categoryName = "Drinks";
            var _category = new Category
            {
                CategoryId = 3,
                CategoryName = "Drinks",
                Description = "Desc",
            };

            mock.Setup(r => r.GetById(_categoryId)).Returns(_category);

            // Act
            var _expected = _categoryServiceMock.GetById(_categoryId);

            // Assert
            Assert.Equal(_categoryId, _expected.Contents.CategoryId);
            Assert.Equal(_categoryName, _expected.Contents.CategoryName);

        }

        #endregion

        #region CountWhere
        [Fact]
        public void CountWhere_ShouldReturnCount_WhenConditionsRight()
        {
            // Arrange
            Expression<Func<Category, bool>> _predicate = r => r.CategoryId > 2;

            // Act
            var _expected = _categoryService.CountWhere(_predicate);

            // Assert
            Assert.True(_expected > 0);
            
        }

        [Fact]
        public async Task CountWhereAsync_ShouldReturnCount_WhenConditionsRight()
        {
            // Arrange
            Expression<Func<Category, bool>> _predicate = r => r.CategoryId > 2;

            // Act
            var _expected = await _categoryService.CountWhereAsync(_predicate);

            // Assert
            Assert.True(_expected > 0);

        }

        [Fact]
        public void CountWhere_ShouldReturnZero_WhenConditionsWrong()
        {
            // Arrange
            Expression<Func<Category, bool>> _predicate = r => r.CategoryId > 259 && r.CategoryName=="Tomatoes";

            // Act
            var _expected = _categoryService.CountWhere(_predicate);

            // Assert
            Assert.Equal(0, _expected);

        }

        [Fact]
        public async Task CountWhereAsync_ShouldReturnZero_WhenConditionsWrong()
        {
            // Arrange
            Expression<Func<Category, bool>> _predicate = r => r.CategoryId > 259 && r.CategoryName == "Tomatoes";

            // Act
            var _expected = await _categoryService.CountWhereAsync(_predicate);

            // Assert
            Assert.Equal(0, _expected);

        }
        #endregion

        #region GetWhere
        [Fact]
        public void GetWhere_ShouldReturnCategories_WhenConditionsRight()
        {
            // Arrange
            Expression<Func<Category, bool>> _predicate = r => r.CategoryId > 2;

            // Act
            var _expected = _categoryService.GetWhere(_predicate);

            // Assert
            Assert.NotNull(_expected.Contents);
            Assert.True(((List<Category>)_expected.Contents).Count > 0);
        }

        [Fact]
        public async Task GetWhereAsync_ShouldReturnCategories_WhenConditionsRight()
        {
            // Arrange
            Expression<Func<Category, bool>> _predicate = r => r.CategoryId > 2;

            // Act
            var _expected = await _categoryService.GetWhereAsync(_predicate);

            // Assert
            Assert.NotNull(_expected.Contents);

        }

        [Fact]
        public void GetWhere_ShouldReturnCategories_WhenConditionsWrong()
        {
            // Arrange
            Expression<Func<Category, bool>> _predicate = r => r.CategoryId > 259 && r.CategoryName == "Tomatoes";

            // Act
            var _expected = _categoryService.GetWhere(_predicate);

            // Assert
            Assert.True(_expected.Success);
            Assert.True(((List<Category>)_expected.Contents).Count == 0);
        }

        [Fact]
        public async Task GetWhereAsync_ShouldReturnCategories_WhenConditionsWrong()
        {
            // Arrange
            Expression<Func<Category, bool>> _predicate = r => r.CategoryId > 259 && r.CategoryName == "Tomatoes";

            // Act
            var _expected = await _categoryService.GetWhereAsync(_predicate);

            // Assert
            Assert.True(_expected.Success);
            Assert.True(((List<Category>)_expected.Contents).Count == 0);

        }
        #endregion

        #region Add

        [Fact]
        public void Add_ShouldReturnCategory_WhenSuccessfulyAdding_WithMock()
        {
            // Arrange
            var _category = new Category
            {
                CategoryName = "Drinks",
                Description = "Desc",
            };

            mock.Setup(r => r.Add(It.IsAny<Category>()));

            // Act
            var _expected = _categoryServiceMock.Add(_category);

            // Assert
            Assert.True(_expected.Success);
            Assert.Equal(_expected.Contents.CategoryName, _category.CategoryName);
            Assert.IsType<Category>(_expected.Contents);
            mock.Verify();

        }

        [Fact]
        public async Task AddAsync_ShouldReturnCategory_WhenSuccessfulyAdding_WithMock()
        {
            // Arrange
            var _category = new Category
            {
                CategoryName = "Drinks",
                Description = "Desc",
            };

            mock.Setup(r => r.AddAsync(It.IsAny<Category>()));

            // Act
            var _expected = await _categoryServiceMock.AddAsync(_category);

            // Assert
            Assert.True(_expected.Success);
            Assert.Equal(_expected.Contents.CategoryName, _category.CategoryName);
            Assert.IsType<Category>(_expected.Contents);
            mock.Verify();
        }

        #endregion

        #region Update

        [Fact]
        public void Update_ShouldReturnCategory_WhenSuccessfulyUpdating_WithMock()
        {
            // Arrange
            var _category = new Category
            {
                CategoryId = 11,
                CategoryName = "Drinks",
                Description = "Desc",
            };

            mock.Setup(r => r.Update(It.IsAny<Category>()));

            // Act
            var _expected = _categoryServiceMock.Update(_category);

            // Assert
            Assert.True(_expected.Success);
            Assert.Equal(_expected.Contents.CategoryName, _category.CategoryName);
            Assert.IsType<Category>(_expected.Contents);
            mock.Verify();
        }

        [Fact]
        public async Task UpdateAsync_ShouldReturnCategory_WhenSuccessfulyUpdating_WithMock()
        {
            // Arrange
            var _category = new Category
            {
                CategoryId = 11,
                CategoryName = "Drinks",
                Description = "Desc",
            };

            mock.Setup(r => r.UpdateAsync(It.IsAny<Category>()));

            // Act
            var _expected = await _categoryServiceMock.UpdateAsync(_category);

            // Assert
            Assert.True(_expected.Success);
            Assert.Equal(_expected.Contents.CategoryName, _category.CategoryName);
            Assert.IsType<Category>(_expected.Contents);
            mock.Verify();
        }

        #endregion

        #endregion

    }
}
