- [ ] No docs yet :(
- [ ] No tests yet ':('x2

И типо SQL:
```
SELECT
  Продукты.имя,
  Категории.имя
FROM
  Продукты
LEFT JOIN
  Категории
ON
 Продукты.id = Категории.id
```
