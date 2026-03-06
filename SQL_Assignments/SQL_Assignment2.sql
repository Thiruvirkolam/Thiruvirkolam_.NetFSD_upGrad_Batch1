--Assignment 2

--Table creation
create table customers(
customer_id int primary key identity(1,1),
first_name varchar(50),
last_name varchar(50)
)

create table stores(
store_id int primary key identity(1,1),
store_name varchar(100)
)

create table brands(
brand_id int primary key identity(1,1),
brand_name varchar(100)
)

create table categories(
category_id int primary key identity(1,1),
category_name varchar(100)
)

create table products(
product_id int primary key identity(1,1),
product_name varchar(100),
brand_id int,
category_id int,
model_year int,
list_price decimal(10,2),
foreign key (brand_id) references brands(brand_id),
foreign key (category_id) references categories(category_id)
)

create table orders(
order_id int primary key identity(1,1),
customer_id int,
store_id int,
order_date date,
order_status int,
foreign key (customer_id) references customers(customer_id),
foreign key (store_id) references stores(store_id)
)

create table order_items(
order_item_id int primary key identity(1,1),
order_id int,
product_id int,
quantity int,
list_price decimal(10,2),
discount decimal(4,2),
foreign key (order_id) references orders(order_id),
foreign key (product_id) references products(product_id)
)

create table stocks(
store_id int,
product_id int,
quantity int,
primary key(store_id, product_id),
foreign key (store_id) references stores(store_id),
foreign key (product_id) references products(product_id)
)
  

--inserting values
  insert into customers values
('Rahul','Thiru'),
('Kowshik','Ashwin'),
('Rithick','Kishore')

insert into stores values
('Chennai Store'),
('Bangalore Store')

insert into brands values
('Nike'),
('Adidas')

insert into categories values
('Shoes'),
('Clothing')

insert into products values
('Running Shoes',1,1,2023,1200),
('T Shirt',2,2,2022,800),
('Sneakers',1,1,2023,600)

insert into orders values
(1,1,'2025-03-01',1),
(2,2,'2025-03-02',4),
(3,1,'2025-03-03',4)

insert into order_items values
(1,1,2,1200,0.10),
(2,2,1,800,0.05),
(3,3,3,600,0.00)

insert into stocks values
(1,1,50),
(1,2,30),
(2,1,40),
(2,3,25)
  

--level 1 problem 1
select c.first_name,c.last_name,o.order_id,o.order_date,o.order_status
from customers c inner join orders o on c.customer_id = o.customer_id
where o.order_status = 1 or o.order_status = 4
order by o.order_date desc

--level 1 problem 2
select p.product_name,b.brand_name,c.category_name,p.model_year,p.list_price
from products p inner join brands b on p.brand_id = b.brand_id inner join categories c
on p.category_id = c.category_id
where p.list_price > 500
order by p.list_price asc

--level 2 problem 1
select s.store_name,sum(oi.quantity * oi.list_price * (1 - oi.discount)) as total_sales
from stores s inner join orders o on s.store_id = o.store_id inner join order_items oi on o.order_id = oi.order_id
where o.order_status = 4
group by s.store_name
order by total_sales desc

--level 2 problem 2
select p.product_name,s.store_name,st.quantity as available_stock,isnull(sum(oi.quantity),0) as total_quantity_sold
from stocks st inner join products p on st.product_id = p.product_id inner join stores s on st.store_id = s.store_id
left join order_items oi on st.product_id = oi.product_id
group by p.product_name,s.store_name,st.quantity

order by p.product_name
