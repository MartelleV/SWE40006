-- StudentPortfolio Database Schema
-- This is optional - the application works without a database
-- Use this if you want to store data in MySQL/MariaDB instead of in-memory arrays

-- Create database
CREATE DATABASE IF NOT EXISTS student_portfolio
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE student_portfolio;

-- Student information table
CREATE TABLE IF NOT EXISTS students (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    student_id VARCHAR(50) NOT NULL UNIQUE,
    unit VARCHAR(255) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Skills table
CREATE TABLE IF NOT EXISTS skills (
    id INT AUTO_INCREMENT PRIMARY KEY,
    student_id INT NOT NULL,
    skill_name VARCHAR(100) NOT NULL,
    FOREIGN KEY (student_id) REFERENCES students(id) ON DELETE CASCADE,
    INDEX idx_student_id (student_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Genres table
CREATE TABLE IF NOT EXISTS genres (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL UNIQUE,
    description VARCHAR(255),
    emoji VARCHAR(10),
    color VARCHAR(7)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Artists table
CREATE TABLE IF NOT EXISTS artists (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    genre VARCHAR(100),
    image_path VARCHAR(500),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Songs table
CREATE TABLE IF NOT EXISTS songs (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    artist VARCHAR(255) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Albums table
CREATE TABLE IF NOT EXISTS albums (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    artist VARCHAR(255) NOT NULL,
    image_path VARCHAR(500),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Insert sample data
INSERT INTO students (name, student_id, unit) VALUES
('Vu Phan Hoang An', '104775412', 'SWE40006 Software Deployment and Evolution');

INSERT INTO skills (student_id, skill_name) VALUES
(1, 'C#'),
(1, 'ASP.NET Core'),
(1, 'Azure'),
(1, 'PHP');

INSERT INTO genres (name, description, emoji, color) VALUES
('Rock', 'Hard Rock & Progressive Rock', '🎸', '#ef4444'),
('Blues', 'Blues & Soul', '🎵', '#3b82f6'),
('Jazz', 'Jazz & Fusion', '🎷', '#f59e0b'),
('Dance', 'Electronic & Dance', '🎧', '#a78bfa');

INSERT INTO artists (name, genre) VALUES
('Daft Punk', 'Dance'),
('Led Zeppelin', 'Rock'),
('Al Di Meola', 'Jazz'),
('Jeff Beck', 'Jazz-Rock'),
('Gary Moore', 'Blues-Rock'),
('The Goo Goo Dolls', 'Rock'),
('Fleetwood Mac', 'Rock'),
('Guns N'' Roses', 'Rock'),
('Pink Floyd', 'Rock'),
('Eric Clapton', 'Blues-Rock');

INSERT INTO songs (title, artist) VALUES
('Iris', 'The Goo Goo Dolls'),
('Stairway to Heaven', 'Led Zeppelin'),
('Touch', 'Daft Punk'),
('November Rain', 'Guns N'' Roses'),
('Since I''ve Been Loving You', 'Led Zeppelin'),
('Kashmir', 'Led Zeppelin'),
('Comfortably Numb', 'Pink Floyd'),
('Silver Springs', 'Fleetwood Mac'),
('The Loner', 'Gary Moore'),
('Black Dog', 'Led Zeppelin'),
('Whole Lotta Love', 'Led Zeppelin'),
('Parisienne Walkways', 'Gary Moore'),
('Cause We''ve Ended As Lovers', 'Jeff Beck'),
('People Get Ready', 'Jeff Beck, Rod Stewart'),
('Layla', 'Derek and the Dominos'),
('When The Levee Breaks', 'Led Zeppelin'),
('Babe I''m Gonna Leave You', 'Led Zeppelin'),
('Iron Man', 'Black Sabbath'),
('Every Breath You Take', 'The Police'),
('Beat It', 'Michael Jackson, Eddie Van Halen'),
('Purple Rain', 'Prince and the Revolution'),
('Sweet Child O'' Mine', 'Guns N'' Roses'),
('Midnight Tango', 'Al Di Meola');

INSERT INTO albums (title, artist) VALUES
('Led Zeppelin IV', 'Led Zeppelin'),
('Rumours', 'Fleetwood Mac'),
('Use Your Illusions', 'Guns N'' Roses'),
('Dizzy Up The Girl', 'The Goo Goo Dolls'),
('Led Zeppelin II', 'Led Zeppelin'),
('Wild Frontier', 'Gary Moore'),
('Blow By Blow', 'Jeff Beck'),
('Paranoid', 'Black Sabbath'),
('OK Computer', 'Radiohead'),
('The Dark Side of The Moon', 'Pink Floyd'),
('Communique', 'Dire Straits'),
('Random Access Memories', 'Daft Punk'),
('Van Halen', 'Van Halen');
