create table orderitems
(
order_num int not null,
order_item int not null
primary key(order_num,order_item));

select * from orderitems;
