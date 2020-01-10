CREATE TABLE public.capsula
(
    "ID" serial NOT NULL,
    "Descricao" character varying(30),
    "Forca" integer,
    PRIMARY KEY ("ID")
)
WITH (
    OIDS = FALSE
);

ALTER TABLE public.capsula
    OWNER to postgres;
	




CREATE TABLE public.receita
(
    "ID" serial NOT NULL,
    "Descricao" character varying(50),
    PRIMARY KEY ("ID")
)
WITH (
    OIDS = FALSE
);

ALTER TABLE public.receita
    OWNER to postgres;
	
	
	
	
	
CREATE TABLE public.capsulas_receita
(
    "ID" serial NOT NULL,
    "Receita_ID" integer,
    "Capsula_ID" integer,
    "Quantidade" integer,
    PRIMARY KEY ("ID")
)
WITH (
    OIDS = FALSE
);

ALTER TABLE public.capsulas_receita
    OWNER to postgres;
	
	
	
	


CREATE TABLE public.capsulas_estoque
(
    "ID" serial NOT NULL,
    "Tipo" integer,
    "Validade" date,
    "Quantidade" integer,
    PRIMARY KEY ("ID")
)
WITH (
    OIDS = FALSE
);

ALTER TABLE public.capsulas_estoque
    OWNER to postgres;
	
	
	
	
	

CREATE TABLE public.avaliacao
(
    "ID" serial NOT NULL,
    "Receita_ID" integer,
    "Nota" integer,
    "Usuario" character varying(50),
    "Comentario" text,
    PRIMARY KEY ("ID")
)
WITH (
    OIDS = FALSE
);

ALTER TABLE public.avaliacao
    OWNER to postgres;