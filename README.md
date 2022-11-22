# Решение задачи по MS SQL:
    SELECT product.name [продукт], category.name [категория] FROM Products product
        LEFT FOIN ProductCategory productcategory ON product.id = productcategory.products_id
        INNER JOIN Category category ON category.id = productcategory.category_id
    ORDER BY product.name;
