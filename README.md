Пусть есть таблицы Products(id, name), Category(id, name), Products2Category(id_prod, id_cat)

SELECT Products.name, Category.name
FROM Products
LEFT JOIN Products2Category ON Products.id = Products2Category.id_prod
LEFT JOIN Category ON Products2Category.id_cat = Category.id