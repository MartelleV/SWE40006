#!/bin/bash
# Update system
yum update -y

# Install Apache, PHP, and MySQL
amazon-linux-extras enable php8.1
yum clean metadata
yum install -y httpd php php-mysqlnd mariadb105-server wget tar

# Start and enable Apache
systemctl start httpd
systemctl enable httpd

# Start and enable MariaDB
systemctl start mariadb
systemctl enable mariadb

# Download WordPress
cd /tmp
wget https://wordpress.org/latest.tar.gz
tar -xzf latest.tar.gz
# Remove default Apache welcome page
rm -rf /var/www/html/*
cp -r wordpress/* /var/www/html/

# Set permissions
chown -R apache:apache /var/www/html/
find /var/www/html -type d -exec chmod 755 {} \;
find /var/www/html -type f -exec chmod 644 {} \;

# Configure MariaDB
# Automatically sets the root password and removes anonymous users
mysqladmin -u root password 'SecureRootPassword123'
mysql -u root -p'SecureRootPassword123' -e "DELETE FROM mysql.user WHERE User='';"
mysql -u root -p'SecureRootPassword123' -e "DROP DATABASE IF EXISTS test;"
mysql -u root -p'SecureRootPassword123' -e "FLUSH PRIVILEGES;"
# Create WordPress database and user
mysql -u root -p'SecureRootPassword123' -e "CREATE DATABASE wordpress;"
mysql -u root -p'SecureRootPassword123' -e "CREATE USER 'wpuser'@'localhost' IDENTIFIED BY 'wpPassword123';"
mysql -u root -p'SecureRootPassword123' -e "GRANT ALL PRIVILEGES ON wordpress.* TO 'wpuser'@'localhost';"
mysql -u root -p'SecureRootPassword123' -e "FLUSH PRIVILEGES;"

# Create WordPress config
cd /var/www/html/
cp wp-config-sample.php wp-config.php
sed -i 's/database_name_here/wordpress/' wp-config.php
sed -i 's/username_here/wpuser/' wp-config.php
sed -i 's/password_here/wpPassword123/' wp-config.php

# Configure Apache to allow .htaccess overrides
sed -i '/<Directory "\/var\/www\/html">/,/<\/Directory>/ s/AllowOverride None/AllowOverride All/' /etc/httpd/conf/httpd.conf

# Restart Apache
systemctl restart httpd