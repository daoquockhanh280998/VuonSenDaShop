# Tạo dự án MVC
# 1/ Ta Tạo 1 Blank Solution chứ dự án
# 2/ Tạo dự án MVC trong Blank vừa tạo
# 3/ kết nối git và tạo Repositories trên git 
# 4/ tạo các Branch(chi nhánh) cho git
	-sẽ có 2 nhánh chính và các nhánh feature(đặc tính)
		-Branch Maser : thường k chứa gì cả chỉ chứa file README.md
		-Branch Develop: nhánh phát triển
		-Các nhánh feature sẽ dc đặt tên như sao vd feature/solution_folder sao đó ta tạo pull request vào nhánh develop cho người nhận có thể xem review code
			-khi đã dc merged  pull request thì thằng develop sẽ có code mới nhất
# 5/ Solution Struce(có 2 mô hình khi triển khai dự án)
	-Mô hình N layer(gồm 3 tầng data, business, prenstation) theo hướng data driven design tức là thiết kế theo hướng dữ liệu như bảng gì data như thế nào
	-Mô hình DDD (domain driven design) mô hình này hướng theo khi nghiệp vụ phức tạp, theo entity 
# 6/ Tiếp Đến Ta tạo Class Libary cho Các Tầng (Data,Application) lưu ý điều tạo trên nhánh feature và tất cả phải cùng phiên bản
# 7/ Thiết kế hệ thống 
	- Về bản trong data bán hàng
		+Products
		+ProductsMainCategory
		+ProductsCategory
		+ProductInCategory (phòng trường hợp product có nhiều categories)
		+Carts
		+Order
		+OderDetails
		+Articles
		+ArticlesMainCategory
		+ArticlesCategory
		+Transactions
		+Contacs
		+Lagagues
		+ProductTransactions
		+CategoriesTransactions
	- User gồm id,username,password,Phone,email,LastLoginDate
# 8/ tạo Entity Class và cài đặt EF core