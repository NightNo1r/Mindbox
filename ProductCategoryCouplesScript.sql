-- Так как скрипт создания таблиц в задании отсутствует, представим, что
--  Products - имя таблицы, хранящее информацию о продуктах
--  Categories - имя таблицы, хранящее информацию о категориях
--  ProductCategory - имя таблицы, хранящее информацию о связи продуктов и категорий (реализация связи M:M)

SELECT p.Name, c.Name
FROM Products p
LEFT JOIN ProductCategory pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.Id