infrastucture, cơ sở hạ tầng
utilities, tiện ích
constant, không thay đổi
exception, ngoại lệ
domain, miền
catalog, mục lục
common, phổ thông
role, vai diễn
coupon, phiếu mua hàng
enumerate(enum), liệt kê
migration, sự di cư
initial, ban đầu
dependencies, sự phụ thuộc
integration, hội nhập


1. Infrastucture Cơ sở hạ tầng (View Model, Utilitiest)
2. Domain Miền (Tầng sử lý nghiệp vụ 'Service') (Data, Application)
3. Hosts Máy chủ




add-migration
update-database

WebApp và AdminApp controller sẽ gọi đến ApiIntegration(ApiIntegration sẽ lấy dữ liệu từ DB load lên"chỉ ApiIntegration giao tiếp với DB")
BackEndApi controller sẽ gọi đến những service trong Application(Domain)thực hiện các chức năng xem, thêm, sửa, xoá... trong AdminApp.