# DishOrderSystem（数据库课设，餐饮点菜系统，winform）

>1st update in 2017.09.10, Friday

>2nd update in 2017.12.07, Thursday

## 大体情况
1. IDE：VS 2013 community, sql server 2008, Windows 10家庭中文版
2. 切勿在未配置的数据库的情况下直接运行.exe。配置数据库可以直接导入根目录下的`点菜系统.bacpac`，然后在配置文件修改连接字符串即可。

## 当时遗留的认为应当实现但没实现的功能
1. 不允许修改性别。
2. 如果服务员或厨师在工作，应当拒绝修改工号、姓名、分工。
1. 应当定期检查菜谱中的菜的种类是否在厨师分工中都有。
1. 客人表应该设一个id，不能用tellphone，因为主码理应不能修改，但tellphone是可以修改的。
1. CustomerForm结束后要注意清空listbox内容和让textbox不要再只读了，不然之后没法继续输入
