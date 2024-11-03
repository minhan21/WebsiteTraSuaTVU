Website Bán Trà Sữa - Bubble Tea E-commerce Platform
📝 Mô tả dự án
Hệ thống website bán trà sữa được xây dựng bằng ASP.NET Core MVC, cho phép khách hàng đặt đồ uống trực tuyến và quản lý cửa hàng trà sữa một cách hiệu quả.
🚀 Tính năng chính
Dành cho khách hàng

Đăng ký/Đăng nhập tài khoản
Xem danh sách và chi tiết sản phẩm
Tìm kiếm và lọc sản phẩm theo danh mục
Thêm sản phẩm vào giỏ hàng
Tùy chỉnh topping và độ ngọt
Thanh toán trực tuyến/COD
Theo dõi trạng thái đơn hàng
Đánh giá và bình luận sản phẩm

Dành cho Admin

Quản lý danh mục sản phẩm
Quản lý sản phẩm (thêm/sửa/xóa)
Quản lý đơn hàng
Quản lý khách hàng
Thống kê doanh thu
Quản lý khuyến mãi
Phân quyền người dùng

🛠 Công nghệ sử dụng

ASP.NET Core MVC (.NET 7.0)
Entity Framework Core
SQL Server
HTML5/CSS3
JavaScript/jQuery
Bootstrap 5
SignalR (cho real-time notifications)

📦 Yêu cầu hệ thống

.NET SDK 7.0 trở lên
SQL Server 2019 trở lên
Visual Studio 2022 hoặc VS Code
Git

⚙️ Hướng dẫn cài đặt

Clone repository

bashCopygit clone https://github.com/your-username/bubble-tea-website.git
cd bubble-tea-website

Cập nhật connection string


Mở file appsettings.json
Chỉnh sửa connection string phù hợp với máy local


Khởi tạo database

bashCopydotnet ef database update

Chạy ứng dụng

bashCopydotnet run
🗄️ Cấu trúc thư mục
CopyBubbleTeaWebsite/
├── src/
│   ├── BubbleTeaWebsite.Web/           # Project chính
│   ├── BubbleTeaWebsite.Core/          # Business logic
│   ├── BubbleTeaWebsite.Infrastructure/# Data access layer
│   └── BubbleTeaWebsite.Tests/         # Unit tests
├── docs/                               # Documentation
└── scripts/                            # Database scripts
📊 Cấu trúc database

Products: Quản lý sản phẩm
Categories: Danh mục sản phẩm
Orders: Đơn hàng
OrderDetails: Chi tiết đơn hàng
Users: Người dùng
Roles: Phân quyền
Reviews: Đánh giá sản phẩm
Promotions: Khuyến mãi

🔒 Authentication & Authorization

JWT Authentication
Role-based Authorization
OAuth 2.0 (Google, Facebook login)

🔨 Development

Code Style


Tuân thủ C# Coding Conventions
Sử dụng English cho tên biến, hàm
Comment đầy đủ cho các hàm quan trọng


Branching Strategy


main: production code
develop: development code
feature/*: các tính năng mới
hotfix/*: sửa lỗi gấp


Unit Testing


xUnit cho testing framework
Moq cho mocking
Code coverage > 80%

📝 API Documentation
API documentation được tạo tự động với Swagger UI:

Development: https://localhost:5001/swagger
Production: https://api.bubbletea.com/swagger

🤝 Contributing

Fork repository
Tạo feature branch (git checkout -b feature/AmazingFeature)
Commit changes (git commit -m 'Add some AmazingFeature')
Push to branch (git push origin feature/AmazingFeature)
Tạo Pull Request

⚖️ License
Distributed under the MIT License. See LICENSE for more information.
📧 Contact
Email: support@bubbletea.com
Website: https://bubbletea.com
🙏 Acknowledgments

ASP.NET Core
Bootstrap
Font Awesome
