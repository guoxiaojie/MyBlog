--nlog_user�û���id��password(����)��last_login(�ϴ�һ��¼ʱ��)��is_superuser(�Ƿ����Ա)��username(�û���)��firstname(��)��lastname(��)��email(����)��is_staff()��is_active()��date_joined(����ʱ��)��avatar(ͷ��)��qq(QQ����)��mobile(�ֻ�����)��url(���˲��͵�ַ)��
--blog_tag��ǩ��id��tag(��ǩ��)��
--blog_category�����id��name(��������)��index(��������)��
--blog_article���±�id��title(���±���)��desc(��������)��content(��������)��ckick_count(�������)��is_recommend(�Ƿ��Ƽ�)��date_publish(����ʱ��)��user(�û�)��category(����)��tag(��ǩ)��
--blog_comment���۱�id��content(��������)��username(�û���)��email(�����ַ)��url(������ҳ��ַ)��date_publish(����ʱ��)��user(�û�)��article(����)��pid(��������)��
--blog_links�������ӡ�id��title(����)��description(������������)��callback_url(url��ַ)��date_publish(����ʱ��)��index(����˳��)��
--blog_ad��桾id��title(������)��description(�������)��image_url(ͼƬ·��)��callback_url(�ص�url)��date_publish(����ʱ��)��index(����˳��)��


create database Myblog
use Myblog



create table nlog_user
(
 id int primary key identity not null, --����id
 username nvarchar(50),--�û���
 [password] nvarchar(50) ,--����
 last_login datetime,--�ϴε�¼ʱ��
 last_ip nvarchar(50) ,--�ϴε�¼ip
 is_superuser int,--�Ƿ����Ա
 truename nvarchar(50),--��ʵ����
 email nvarchar(50),--����
 qq nvarchar(50),--qq����
 moblie nvarchar(50),--�ֻ���
 intime datetime ,--����ʱ��
 url nvarchar(50)--���˲��͵�ַ
)


create table blog_tag
(
id int primary key identity ,--��������
tag  nvarchar(50) --��ǩ
)


create table  blog_category
(
id int primary key identity ,--��������
name nvarchar(50),--��������
[index] int --����
)

create table blog_article
(
id int primary key identity ,--��������
title nvarchar(50),--���±���
[desc] nvarchar(50),--����
content nvarchar(4000),--��������
click_count int ,--�������
is_recommend int ,--�Ƿ��Ƽ�
date_publish datetime,--����ʱ��
username nvarchar(50),--�û���
category int,--����id
tag int,--��ǩid
isdel int --�Ƿ�ɾ��
)


create table blog_comment
(
id int primary key identity ,--��������
content nvarchar(4000), --(��������)
username nvarchar(50),--�û���
email nvarchar(50),--����
url nvarchar(50),--���˲��͵�ַ
date_publish datetime ,--����ʱ��
articleid int,--����id
pid int, --�������� id
isdel int --�Ƿ�ɾ��
)


create table blog_links
(
id int primary key identity ,--��������
title nvarchar(50),--����
[description] nvarchar(400),--������������
callback_url nvarchar(100),--url��ַ
date_publish datetime,--����ʱ��
[index] int ,--����
)


create table blog_ad
(
id int primary key identity ,--��������
title nvarchar(200),--����
[description] nvarchar(4000) ,--�������
imgurl nvarchar(200) ,--ͼƬ��ַ
callback_url nvarchar(200),--������ӵ�ַ
date_publish datetime,--����ʱ��
[index] int ,--����
isdel int ,--�Ƿ�ɾ��
)