CREATE DATABASE IF NOT EXISTS seller_center
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;
USE seller_center;

-- =========================
-- 1. employees
-- =========================
CREATE TABLE employees (
    id BIGINT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(100) NOT NULL,
    email VARCHAR(255) NOT NULL,
    password_hash VARCHAR(500) NOT NULL,
    full_name VARCHAR(255) NULL,
    phone VARCHAR(30) NULL,
    role VARCHAR(50) NOT NULL DEFAULT 'STAFF',
    is_active TINYINT(1) NOT NULL DEFAULT 1,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    UNIQUE KEY uk_employees_username (username),
    UNIQUE KEY uk_employees_email (email)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


-- =========================
-- 2. facebook_apps
-- =========================
CREATE TABLE facebook_apps (
    id BIGINT AUTO_INCREMENT PRIMARY KEY,
    app_name VARCHAR(255) NOT NULL,
    app_id VARCHAR(100) NOT NULL,
    app_secret VARCHAR(500) NULL,
    is_active TINYINT(1) NOT NULL DEFAULT 1,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    UNIQUE KEY uk_facebook_apps_app_id (app_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


-- =========================
-- 3. facebook_app_permissions
-- =========================
CREATE TABLE facebook_app_permissions (
    id BIGINT AUTO_INCREMENT PRIMARY KEY,
    facebook_app_id BIGINT NOT NULL,
    permission_name VARCHAR(100) NOT NULL,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    UNIQUE KEY uk_fb_app_permission (facebook_app_id, permission_name),
    CONSTRAINT fk_permission_facebook_app
        FOREIGN KEY (facebook_app_id)
        REFERENCES facebook_apps(id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


-- =========================
-- 4. employee_facebook_apps
-- =========================
CREATE TABLE employee_facebook_apps (
    id BIGINT AUTO_INCREMENT PRIMARY KEY,
    employee_id BIGINT NOT NULL,
    facebook_app_id BIGINT NOT NULL,
    can_view TINYINT(1) NOT NULL DEFAULT 1,
    can_get_token TINYINT(1) NOT NULL DEFAULT 0,
    can_post TINYINT(1) NOT NULL DEFAULT 0,
    can_update TINYINT(1) NOT NULL DEFAULT 0,
    can_delete TINYINT(1) NOT NULL DEFAULT 0,
    assigned_by BIGINT NULL,
    assigned_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    UNIQUE KEY uk_employee_facebook_app (employee_id, facebook_app_id),

    CONSTRAINT fk_efa_employee
        FOREIGN KEY (employee_id)
        REFERENCES employees(id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,

    CONSTRAINT fk_efa_facebook_app
        FOREIGN KEY (facebook_app_id)
        REFERENCES facebook_apps(id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,

    CONSTRAINT fk_efa_assigned_by
        FOREIGN KEY (assigned_by)
        REFERENCES employees(id)
        ON DELETE SET NULL
        ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


-- =========================
-- 5. login_sessions
-- =========================
CREATE TABLE login_sessions (
    id BIGINT AUTO_INCREMENT PRIMARY KEY,
    employee_id BIGINT NOT NULL,
    session_token VARCHAR(500) NOT NULL,
    login_time DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    logout_time DATETIME NULL,
    ip_address VARCHAR(50) NULL,
    device_name VARCHAR(255) NULL,
    is_active TINYINT(1) NOT NULL DEFAULT 1,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    UNIQUE KEY uk_login_sessions_token (session_token),
    KEY idx_login_sessions_employee_id (employee_id),

    CONSTRAINT fk_login_sessions_employee
        FOREIGN KEY (employee_id)
        REFERENCES employees(id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


-- =========================
-- 6. packing_sessions
-- =========================
CREATE TABLE packing_sessions (
    id BIGINT AUTO_INCREMENT PRIMARY KEY,
    barcode VARCHAR(255) NOT NULL,
    local_path VARCHAR(500) NULL,
    created_at DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
    youtube_url VARCHAR(500) NULL,

    KEY idx_packing_sessions_barcode (barcode)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


-- =========================
-- 7. products
-- =========================
CREATE TABLE products (
    id BIGINT AUTO_INCREMENT PRIMARY KEY,
    product_code VARCHAR(100) NOT NULL,
    product_name VARCHAR(255) NOT NULL,
    description TEXT NULL,
    image_url TEXT NULL,
    video_url TEXT NULL,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    UNIQUE KEY uk_products_product_code (product_code)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


-- =========================
-- 8. post_content
-- =========================
CREATE TABLE post_content (
    id INT AUTO_INCREMENT PRIMARY KEY,
    product_code VARCHAR(100) NOT NULL,
    title VARCHAR(255) NULL,
    content TEXT NULL,
    hook VARCHAR(500) NULL,
    image_url_1 VARCHAR(500) NULL,
    image_url_2 VARCHAR(500) NULL,
    image_url_3 VARCHAR(500) NULL,
    image_url_4 VARCHAR(500) NULL,
    image_url_5 VARCHAR(500) NULL,
    video_url VARCHAR(500) NULL,
    hashtag VARCHAR(500) NULL,
    created_at DATETIME NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    KEY idx_post_content_product_code (product_code),

    CONSTRAINT fk_post_content_product
        FOREIGN KEY (product_code)
        REFERENCES products(product_code)
        ON DELETE CASCADE
        ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;


-- =========================
-- 9. prompt_templates
-- =========================
CREATE TABLE prompt_templates (
    id BIGINT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    platform VARCHAR(50) NOT NULL,
    post_type VARCHAR(50) NOT NULL,
    template_content TEXT NOT NULL,
    is_active TINYINT(1) NOT NULL DEFAULT 1,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    KEY idx_prompt_templates_platform (platform),
    KEY idx_prompt_templates_post_type (post_type)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;