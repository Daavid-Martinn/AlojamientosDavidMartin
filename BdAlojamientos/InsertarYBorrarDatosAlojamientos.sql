USE AlojamientosDavidMartin
GO

-- 1. BORRADO DE DATOS (En orden inverso a las FK)
DELETE FROM PAGOS;
DELETE FROM RESERVAS;
DELETE FROM UNIDADES_ALOJAMIENTO;
DELETE FROM ESTABLECIMIENTOS;
DELETE FROM CLIENTES;
DELETE FROM CATEGORIAS;


-- 2. INSERCIÓN DE DATOS

-- Categorías
INSERT INTO CATEGORIAS (NOMBRE_CATEGORIA) VALUES 
('Hotel 4 Estrellas'),
('Apartamento Turístico'),
('Casa Rural');

-- Clientes
INSERT INTO CLIENTES (DNI_NIE, NOMBRE, APELLIDOS, TELEFONO, EMAIL) VALUES
('12345678A', 'Juan', 'García Pérez', '600111222', 'juan.garcia@email.com'),
('87654321B', 'María', 'López Iturbide', '600333444', 'm.lopez@email.com'),
('45678912C', 'Carlos', 'Ruiz Zafón', '611555666', NULL);

-- Establecimientos (Asumiendo IDs 1, 2, 3 por el IDENTITY)
INSERT INTO ESTABLECIMIENTOS (NOMBRE_COMERCIAL, DIRECCION, TELEFONO, EMAIL, IDCATEGORIA) VALUES
('Hotel Sol y Mar', 'Avda. Mediterráneo 45, Valencia', '963000111', 'info@solymar.com', 1),
('Apartamentos Centro', 'Calle Mayor 10, Madrid', '912000222', 'reservas@apcenter.com', 2),
('La Choza del Valle', 'Camino del Río s/n, Asturias', '985000333', NULL, 3);

-- Unidades de Alojamiento (Clave compuesta: IDESTABLECIMIENTO + NUMERO)
INSERT INTO UNIDADES_ALOJAMIENTO (IDESTABLECIMIENTO, NUMERO, NOMBRE_UNIDAD, CAPACIDAD_MAX, ESTADO, PRECIO_NOCHE, DESCRIPCION) VALUES
(1, 101, 'Doble Estándar', 2, 'Disponible', 85.00, 'Habitación con vistas al patio'),
(1, 102, 'Suite Imperial', 4, 'Ocupada', 150.00, 'Terraza privada y jacuzzi'),
(2, 1, 'Estudio A', 2, 'Disponible', 60.50, 'Ideal para parejas'),
(2, 2, 'Apartamento Familiar', 6, 'Mantenimiento', 110.00, 'Tres dormitorios y cocina completa'),
(3, 10, 'Cabaña Roble', 4, 'Disponible', 95.00, 'Chimenea de leña incluida');

-- Reservas
-- Nota: La fianza puede ser NULL
INSERT INTO RESERVAS (IDESTABLECIMIENTO, NUMERO_UNIDAD, IDCLIENTE, FECHA_ENTRADA, FECHA_SALIDA, CANTIDAD_PERSONAS, ESTADO_RESERVA, FIANZA, IMPORTE_ESTIMADO) VALUES
(1, 101, 1, '2026-05-10', '2026-05-15', 2, 'Confirmada', 50.00, 425.00),
(2, 1, 2, '2026-06-01', '2026-06-03', 1, 'Finalizada', NULL, 121.00),
(3, 10, 3, '2026-07-20', '2026-07-25', 3, 'Pendiente', 100.00, 475.00);

-- Pagos
INSERT INTO PAGOS (IDRESERVA, IMPORTE, FECHA_PAGO, METODO_PAGO) VALUES
(1, 50.00, '2026-04-01', 'Tarjeta de Crédito'), -- Pago de fianza
(2, 121.00, '2026-06-03', 'Efectivo'); -- Pago final al salir