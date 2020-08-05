ALTER TABLE IF EXISTS ONLY show_genre
    DROP CONSTRAINT IF EXISTS fk_show_genres_genre_id CASCADE;
ALTER TABLE IF EXISTS ONLY show_genre
    DROP CONSTRAINT IF EXISTS fk_show_genres_show_id CASCADE;
ALTER TABLE IF EXISTS ONLY season
    DROP CONSTRAINT IF EXISTS fk_seasons_show_id CASCADE;
ALTER TABLE IF EXISTS ONLY episode
    DROP CONSTRAINT IF EXISTS fk_episodes_season_id CASCADE;
ALTER TABLE IF EXISTS ONLY show_character
    DROP CONSTRAINT IF EXISTS fk_show_characters_actor_id CASCADE;
ALTER TABLE IF EXISTS ONLY show_character
    DROP CONSTRAINT IF EXISTS fk_show_characters_show_id CASCADE;


DROP TABLE IF EXISTS genre CASCADE;
DROP TABLE IF EXISTS show CASCADE;
DROP TABLE IF EXISTS show_genre CASCADE;
DROP TABLE IF EXISTS season CASCADE;
DROP TABLE IF EXISTS episode CASCADE;
DROP TABLE IF EXISTS actor CASCADE;
DROP TABLE IF EXISTS show_character CASCADE;


CREATE TABLE genre
(
    genre_id SERIAL PRIMARY KEY NOT NULL,
    name     VARCHAR(30)        NOT NULL
);


CREATE TABLE show
(
    show_id  INTEGER PRIMARY KEY NOT NULL,
    title    VARCHAR(200)        NOT NULL,
    year     DATE                NULL,
    overview TEXT,
    runtime  SMALLINT,
    trailer  VARCHAR(200),
    homepage VARCHAR(200),
    rating   NUMERIC
);


CREATE TABLE show_genre
(
    show_genre_id SERIAL PRIMARY KEY NOT NULL,
    show_id       INTEGER            NOT NULL,
    genre_id      INTEGER            NOT NULL
);


CREATE TABLE season
(
    season_id     INTEGER PRIMARY KEY NOT NULL,
    season_number SMALLINT            NOT NULL,
    title         VARCHAR(200),
    overview      TEXT,
    show_id       INTEGER             NOT NULL
);


CREATE TABLE episode
(
    episode_id     INTEGER PRIMARY KEY NOT NULL,
    title          VARCHAR(200),
    episode_number SMALLINT            NOT NULL,
    overview       TEXT,
    season_id      INTEGER             NOT NULL
);


CREATE TABLE actor
(
    actor_id  INTEGER PRIMARY KEY NOT NULL,
    name      VARCHAR(200)        NOT NULL,
    birthday  DATE,
    death     DATE,
    biography TEXT
);


CREATE TABLE show_character
(
    show_character_id SERIAL PRIMARY KEY NOT NULL,
    show_id           INTEGER            NOT NULL,
    actor_id          INTEGER            NOT NULL,
    character_name    VARCHAR(200)       NOT NULL
);


ALTER TABLE ONLY show_genre
    ADD CONSTRAINT fk_show_genres_genre_id FOREIGN KEY (genre_id) REFERENCES genre (genre_id);

ALTER TABLE ONLY show_genre
    ADD CONSTRAINT fk_show_genres_show_id FOREIGN KEY (show_id) REFERENCES show (show_id);

ALTER TABLE ONLY season
    ADD CONSTRAINT fk_seasons_show_id FOREIGN KEY (show_id) REFERENCES show (show_id);

ALTER TABLE ONLY episode
    ADD CONSTRAINT fk_episodes_season_id FOREIGN KEY (season_id) REFERENCES season (season_id);

ALTER TABLE ONLY show_character
    ADD CONSTRAINT fk_show_characters_actor_id FOREIGN KEY (actor_id) REFERENCES actor (actor_id);

ALTER TABLE ONLY show_character
    ADD CONSTRAINT fk_show_characters_show_id FOREIGN KEY (show_id) REFERENCES show (show_id);

