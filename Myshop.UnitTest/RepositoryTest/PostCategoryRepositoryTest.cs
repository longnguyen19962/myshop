using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShop.Data.Infrastructure;
using MyShop.Data.Repositories;
using MyShop.Model.Models;
using System.Linq;

namespace Myshop.UnitTest.RepositoryTest
{
    [TestClass] /*Su dung de test Toan bo  Vao Menu Test/Windows/Test Exploror */
    public class PostCategoryRepositoryTest
    {
        private IDbFactory dbFactory;
        private IPostCategoryRepository objRepository;
        private IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()   /* Phuong thuc se thuc hien ngay sau khi chay chuong trinh*/
        {
            //No se khoi tao ra 3 doi tuong nhu sau
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]  /* [TestMethod],[TestInitialize],[TestClass] : la 3 Test Key hay su dung nhat*/
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(1, list.Count);
        }
        //Sau khi da co 1 Test Key muon kiem tra thi lam nhu sau
        /*
         buoc 1: Dat Break (dau do) ngay dau { cua phuong thuc
         Buoc 2: chuot phai /Debug Test
         buoc 3: xem debug nhu binh thuong
             */
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test-category";
            category.Status = true;

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            //Cu moi lan chay thi chi so 1++
            Assert.AreEqual(1, result.ID);
        }
    }
}