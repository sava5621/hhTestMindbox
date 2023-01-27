SELECT products.name, product_tupes.type_name
FROM products LEFT OUTHER JOIN product_tupes
ON products.type_id = product_tupes.id