Select Products.*, Categories.Name
from Products
left join CatergoriesProducts
on CatergoriesProducts.IDProduct = Products.ID
left join Categories
on Categories.ID = CatergoriesProducts.IDCategory

