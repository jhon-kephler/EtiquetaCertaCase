CREATE DATABASE etiquetacertacase;

\c etiquetacertacase;

CREATE TABLE "Product" (
    Id SERIAL PRIMARY KEY NOT NULL,
    Name VARCHAR(100) NOT NULL,
    Category VARCHAR(100) NOT NULL,
    Price NUMERIC NOT NULL
);