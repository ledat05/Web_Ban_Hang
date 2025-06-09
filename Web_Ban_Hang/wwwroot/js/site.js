$(document).ready(function () {
    showQuantityCart();
});
let showQuantityCart = () => {
    $.ajax({
        url: "/CUSTOMER/Cart/GetQuantityOfCart",
        success: function (data) {
            //hien thi so luong san pham trong gio trong _FrontEnd.cshtml
            $(".showcart").text(data.qty);
        }
    });
}
//xử lý sự kiện click cho các liên kết [add to cart]
$(document).on("click", ".addtocart", function (evt) {
    evt.preventDefault();
    let id = $(this).attr("data-productId");
    $.ajax({
        url: "/CUSTOMER/Cart/AddToCartAPI",
        data: { "productId": id },
        success: function (data) {
            //thong bao ket qua
            Swal.fire({
                title: "Product added to cart",
                text: "You clicked the button!",
                icon: "success"
            });
            //hien thi so luong san pham trong gio trong _FrontEnd.cshtml
            showQuantityCart();
        }
    });
})