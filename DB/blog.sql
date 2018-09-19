--nlog_user用户表【id、password(密码)、last_login(上次一登录时间)、is_superuser(是否管理员)、username(用户名)、firstname(姓)、lastname(名)、email(邮箱)、is_staff()、is_active()、date_joined(创建时间)、avatar(头像)、qq(QQ号码)、mobile(手机号码)、url(个人博客地址)】
--blog_tag标签表【id、tag(标签名)】
--blog_category分类表【id、name(分类名称)、index(分类排序)】
--blog_article文章表【id、title(文章标题)、desc(文章描述)、content(文章内容)、ckick_count(点击次数)、is_recommend(是否推荐)、date_publish(发布时间)、user(用户)、category(分类)、tag(标签)】
--blog_comment评论表【id、content(评论内容)、username(用户名)、email(邮箱地址)、url(个人网页地址)、date_publish(发布时间)、user(用户)、article(文章)、pid(父级评论)】
--blog_links友情链接【id、title(标题)、description(友情链接描述)、callback_url(url地址)、date_publish(发布时间)、index(排列顺序)】
--blog_ad广告【id、title(广告标题)、description(广告描述)、image_url(图片路径)、callback_url(回调url)、date_publish(发布时间)、index(排列顺序)】


create database Myblog
use Myblog



create table nlog_user
(
 id int primary key identity not null, --主键id
 username nvarchar(50),--用户名
 [password] nvarchar(50) ,--密码
 last_login datetime,--上次登录时间
 last_ip nvarchar(50) ,--上次登录ip
 is_superuser int,--是否管理员
 truename nvarchar(50),--真实姓名
 email nvarchar(50),--邮箱
 qq nvarchar(50),--qq号码
 moblie nvarchar(50),--手机号
 intime datetime ,--创建时间
 url nvarchar(50)--个人博客地址
)


create table blog_tag
(
id int primary key identity ,--主键自增
tag  nvarchar(50) --标签
)


create table  blog_category
(
id int primary key identity ,--主键自增
name nvarchar(50),--分类名称
[index] int --索引
)

create table blog_article
(
id int primary key identity ,--主键自增
title nvarchar(50),--文章标题
[desc] nvarchar(50),--描述
content nvarchar(4000),--正文内容
click_count int ,--点击次数
is_recommend int ,--是否推荐
date_publish datetime,--发布时间
username nvarchar(50),--用户名
category int,--分类id
tag int,--标签id
isdel int --是否删除
)


create table blog_comment
(
id int primary key identity ,--主键自增
content nvarchar(4000), --(评论内容)
username nvarchar(50),--用户名
email nvarchar(50),--邮箱
url nvarchar(50),--个人博客地址
date_publish datetime ,--发布时间
articleid int,--文章id
pid int, --父级评论 id
isdel int --是否删除
)


create table blog_links
(
id int primary key identity ,--主键自增
title nvarchar(50),--标题
[description] nvarchar(400),--友情链接描述
callback_url nvarchar(100),--url地址
date_publish datetime,--发布时间
[index] int ,--排序
)


create table blog_ad
(
id int primary key identity ,--主键自增
title nvarchar(200),--标题
[description] nvarchar(4000) ,--广告描述
imgurl nvarchar(200) ,--图片地址
callback_url nvarchar(200),--广告链接地址
date_publish datetime,--发布时间
[index] int ,--排序
isdel int ,--是否删除
)