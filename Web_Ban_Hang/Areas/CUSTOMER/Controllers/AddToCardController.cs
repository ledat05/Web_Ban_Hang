//using Microsoft.AspNetCore.Mvc;
//using Web_Ban_Hang.Models;

//namespace Web_Ban_Hang.Controllers
//{
//    public class AddToCardController : Controller
//    {
//        private IProductService _productService;

//        public interface IProductService
//        {
//            product getproductbyid(int id);
//            // các phương thức khác nếu cần
//        }


//        public addtocardcontroller(iproductservice productservice)
//        {
//            _productservice = productservice;
//        }

//        [httppost]
//        public iactionresult addtocart(int id)
//        {
//            var product = _productservice.getproductbyid(id);
//            if (product == null)
//                return notfound();



//            return view(cartitem);
//        }

//        [httppost]
//        public iactionresult updatecart(cartitemviewmodel cartitem)
//        {
//            // xử lý cập nhật số lượng (nếu bạn muốn xử lý server-side)
//            // tính lại tổng tiền
//            return view("addtocart", cartitem);
//        }

//        [httppost]
//        public iactionresult checkout(cartitemviewmodel cartitem)
//        {
//            // xử lý thanh toán
//            // sau khi thanh toán thành công, redirect hoặc thông báo
//            return redirecttoaction("index", "home");
//        }
//    }
//}
