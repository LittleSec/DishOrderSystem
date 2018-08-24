# DishOrderSystem（数据库课设，餐饮点菜系统，winform）

>1st update in 2017.09.10, Friday

>2nd update in 2017.12.07, Thursday

## 大体情况
1. IDE：VS 2013 community, sql server 2008, Windows 10家庭中文版
2. 切勿在未配置的数据库的情况下直接运行.exe。
4. 启动form最好是WelcomeForm.cs或AdminForm.cs或CustomerForm.cs。

## 当时遗留的认为应当实现但没实现的功能
1. 不允许修改性别。
2. 如果服务员或厨师在工作，应当拒绝修改工号、姓名、分工。
1. 应当定期检查菜谱中的菜的种类是否在厨师分工中都有。
1. 客人表应该设一个id，不能用tellphone，因为主码理应不能修改，但tellphone是可以修改的。
1. CustomerForm结束后要注意清空listbox内容和让textbox不要再只读了，不然之后没法继续输入

>3rd update in 2018.08.24

## 数据库文件及配置
1. bacpac-->dacpac，好处就是不需要使用sql server managerment studio来导入数据库了，vs自带能导入dacpac文件。
2. 导入数据库：
    + SQL Server对象资源管理器，如下图：
        ![SQL Server对象资源管理器](.pic/1.png)
    + 选择希望导入的sql Server服务器并展开
    + 右击“数据库”
    + 发布数据层应用程序，按下图完成配置：
    + ![发布数据层应用程序](.pic/2.png)
3. 连接字符串：
    + 解决方案资源管理器
    + 展开项目
    + 双击Properties
    + 点击设置
    + 有一个connDateString的连接字符串，移动到右边“值”那一栏的右边有三个点，点击后按下图完成配置：
    + ![配置连接字符串](.pic/3.png)
4. 数据库ER图：
    ![ER图](.pic/ER.jpg)


