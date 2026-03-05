--Assignment 2

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