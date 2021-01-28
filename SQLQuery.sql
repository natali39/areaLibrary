select
Products.name as 'Наименование продукта',
Categories.name as 'Категория' 
from Products
left join Product_Categories on Products.id = Product_Categories.productId
left join Categories on Categories.id = Product_Categories.categoryId