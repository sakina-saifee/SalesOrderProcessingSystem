USE [imsdb]
GO
/****** Object:  StoredProcedure [dbo].[st_viewProducts]    Script Date: 5/21/2023 10:05:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[st_viewProducts]
as
select 
p.prod_id as 'Product ID',
p.prod_name as 'Product Name',
p.prod_barcode as 'Product Barcode',
format (p.prod_expiry, 'dd-MMM-yyyy')as 'Product Expiry',
p.prod_price as 'Product Price',
c.cat_id as 'Category ID',
c.cat_name as 'Category Name'

from products p
inner join categories c 
on c.cat_id =p.fk_cat_id
order by prod_name asc;

exec st_viewProducts;