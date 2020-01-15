SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'WIN1252';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;
SET default_tablespace = '';
SET default_with_oids = false

CREATE TABLE "public"."avaliacao" (
    "ID" integer NOT NULL,
    "Receita_ID" integer,
    "Nota" integer,
    "Usuario" character varying(50),
    "Comentario" "text"
);
ALTER TABLE "public"."avaliacao" OWNER TO "postgres";
CREATE SEQUENCE "public"."avaliacao_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
ALTER TABLE "public"."avaliacao_ID_seq" OWNER TO "postgres";
ALTER SEQUENCE "public"."avaliacao_ID_seq" OWNED BY "public"."avaliacao"."ID";
CREATE TABLE "public"."capsulas" (
    "ID" integer NOT NULL,
    "Descricao" character varying(30),
    "Forca" integer
);
ALTER TABLE "public"."capsulas" OWNER TO "postgres";
CREATE SEQUENCE "public"."capsula_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
ALTER TABLE "public"."capsula_ID_seq" OWNER TO "postgres";
ALTER SEQUENCE "public"."capsula_ID_seq" OWNED BY "public"."capsulas"."ID";
CREATE TABLE "public"."capsulareceita" (
    "ID" integer NOT NULL,
    "Receita_ID" integer,
    "Capsula_ID" integer,
    "Quantidade" integer
);
ALTER TABLE "public"."capsulareceita" OWNER TO "postgres";
CREATE TABLE "public"."estoque" (
    "ID" integer NOT NULL,
    "Capsula" integer,
    "Validade" "date",
    "Quantidade" integer
);
ALTER TABLE "public"."estoque" OWNER TO "postgres";
CREATE SEQUENCE "public"."capsulas_estoque_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
ALTER TABLE "public"."capsulas_estoque_ID_seq" OWNER TO "postgres";
ALTER SEQUENCE "public"."capsulas_estoque_ID_seq" OWNED BY "public"."estoque"."ID";
CREATE SEQUENCE "public"."capsulas_receita_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
ALTER TABLE "public"."capsulas_receita_ID_seq" OWNER TO "postgres";
ALTER SEQUENCE "public"."capsulas_receita_ID_seq" OWNED BY "public"."capsulareceita"."ID";
CREATE TABLE "public"."receita" (
    "ID" integer NOT NULL,
    "Descricao" character varying(50)
);
ALTER TABLE "public"."receita" OWNER TO "postgres";
CREATE SEQUENCE "public"."receita_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
ALTER TABLE "public"."receita_ID_seq" OWNER TO "postgres";
ALTER SEQUENCE "public"."receita_ID_seq" OWNED BY "public"."receita"."ID";
ALTER TABLE ONLY "public"."avaliacao" ALTER COLUMN "ID" SET DEFAULT "nextval"('"public"."avaliacao_ID_seq"'::"regclass");
ALTER TABLE ONLY "public"."capsulareceita" ALTER COLUMN "ID" SET DEFAULT "nextval"('"public"."capsulas_receita_ID_seq"'::"regclass");
ALTER TABLE ONLY "public"."capsulas" ALTER COLUMN "ID" SET DEFAULT "nextval"('"public"."capsula_ID_seq"'::"regclass");
ALTER TABLE ONLY "public"."estoque" ALTER COLUMN "ID" SET DEFAULT "nextval"('"public"."capsulas_estoque_ID_seq"'::"regclass");
ALTER TABLE ONLY "public"."receita" ALTER COLUMN "ID" SET DEFAULT "nextval"('"public"."receita_ID_seq"'::"regclass");
ALTER TABLE ONLY "public"."avaliacao" ADD CONSTRAINT "avaliacao_pkey" PRIMARY KEY ("ID");
ALTER TABLE ONLY "public"."capsulas" ADD CONSTRAINT "capsula_pkey" PRIMARY KEY ("ID");
ALTER TABLE ONLY "public"."estoque" ADD CONSTRAINT "capsulas_estoque_pkey" PRIMARY KEY ("ID");
ALTER TABLE ONLY "public"."capsulareceita" ADD CONSTRAINT "capsulas_receita_pkey" PRIMARY KEY ("ID");
ALTER TABLE ONLY "public"."receita" ADD CONSTRAINT "receita_pkey" PRIMARY KEY ("ID");


