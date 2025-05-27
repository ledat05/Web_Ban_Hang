//using Microsoft.AspNetCore.Mvc;
//using Web_Ban_Hang.Models;

//namespace Web_Ban_Hang.Controllers
//{
//    public class AddToCardController : Controller
//    {
//        private IProductService _productService;

//        public interface IProductService
//        {
//            Product GetProductById(int id);
//            // các phương thức khác nếu cần
//        }


//        public AddToCardController(IProductService productService)
//        {
//            _productService = productService;
//        }

//        [HttpPost]
//        public IActionResult AddToCart(int id)
//        {
//            var product = _productService.GetProductById(id);
//            if (product == null)
//                return NotFound();

    

//            return View(cartItem);
//        }

//        [HttpPost]
//        public IActionResult UpdateCart(CartItemViewModel cartItem)
//        {
//            // xử lý cập nhật số lượng (nếu bạn muốn xử lý server-side)
//            // tính lại tổng tiền
//            return View("AddToCart", cartItem);
//        }

//        [HttpPost]
//        public IActionResult Checkout(CartItemViewModel cartItem)
//        {
//            // Xử lý thanh toán
//            // Sau khi thanh toán thành công, redirect hoặc thông báo
//            return RedirectToAction("Index", "Home");
//        }
//    }
//}
