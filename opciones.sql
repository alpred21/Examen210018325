--1
SELECT (NOMBRE+' '+APELLIDO)Nombre
FROM CLIENTE C
INNER JOIN PERSONA P ON P.IDPERSONA=C.IDPERSONA

--2
SELECT PR.IDPROVEEDOR ID, PR.NOMBRE Proveedor, SUM(I.TOTAL)Ingresos
FROM PROVEEDOR PR
INNER JOIN INGRESO I ON PR.IDPROVEEDOR = I.IDPROVEEDOR
GROUP BY PR.IDPROVEEDOR, PR.NOMBRE;
--3
SELECT top 1 M.NOMBRE Nombre
FROM MARCA M
INNER JOIN PRODUCTO P ON  P.IDMARCA=M.IDMARCA
INNER JOIN DETALLEVENTA DV ON P.IDPRODUCTO=DV.IDPRODUCTO
GROUP BY M.NOMBRE
ORDER BY COUNT(DV.CANTIDAD) DESC
--4
SELECT SUM(total) AS Total
FROM (  SELECT IDPRODUCTO, SUM(CANTIDAD) AS total
		FROM DETALLEING
		GROUP BY IDPRODUCTO

		UNION 

		SELECT IDPRODUCTO,-SUM(CANTIDAD) AS total
		FROM DETALLEVENTA
		GROUP BY IDPRODUCTO) AS Inventarios;
--5
SELECT P.NOMBRE, DI.FECHAVENC
FROM PRODUCTO P
INNER JOIN DETALLEING DI ON DI.IDPRODUCTO=P.IDPRODUCTO
WHERE YEAR(DI.FECHAVENC) = YEAR(GETDATE()) 
ORDER BY DI.FECHAVENC

--6
SELECT U.NOMBREUSER AS Vendedor,COUNT(DV.IDDETALLEVENTA) Productos_Vendidos
FROM USUARIO U
INNER JOIN VENTA V ON U.IDUSUARIO = V.IDVENDEDOR
INNER JOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA
GROUP BY U.NOMBREUSER;

--7
SELECT C.IDCLIENTE,C.IDPERSONA,CONCAT(P.NOMBRE, ' ', P.APELLIDO) Nombre,SUM(V.TOTAL)  Total_Ingresos
FROM CLIENTE C
INNER JOIN PERSONA P ON C.IDPERSONA = P.IDPERSONA
INNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE
GROUP BY C.IDCLIENTE, C.IDPERSONA, P.NOMBRE, P.APELLIDO;
--8 

SELECT TOP 1 PR.NOMBRE AS Nombre
FROM PROVEEDOR PR
INNER JOIN PROVEE P ON PR.IDPROVEEDOR = P.IDPROVEEDOR
INNER JOIN DETALLEING DI ON P.IDPRODUCTO=DI.IDPRODUCTO
GROUP BY PR.NOMBRE
ORDER BY SUM(DI.CANTIDAD) DESC





















SELECT * FROM DETALLEVENTA
order by IDVENTA
SELECT * FROM DETALLEING
SELECT * FROM PROVEE