insert into Product values(1, 1, 'iPhone 6s Plus 64GB', 700, 1020, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(1, 'LED-backlit IPS LCD, 5.5", Retina HD', 'iOS 9', 5, 12, 'Apple A9 2 cores 64-bit, 1.8 GHz', '2GB', 'No support', '1 Nano SIM', 'WiFi, 3G, 4G LTE Cat 6', '2750 mAh', '64GB', 192)
insert into ProductColor values(1, 'Silver', 100)
insert into ProductColor values(1, 'Gray', 100)
insert into ProductColor values(1, 'Pink Gold', 100)
insert into ProductImage values(1,'https://cdn4.tgdd.vn/Products/Images/42/73704/iphone-6s-plus-64gb-bac-org-1.png')
insert into ProductImage values(1,'https://cdn2.tgdd.vn/Products/Images/42/73704/iphone-6s-plus-64gb-xam-org-1.png')
insert into ProductImage values(1,'https://cdn2.tgdd.vn/Products/Images/42/73704/iphone-6s-plus-64gb-vang-hong-org-1.png')

update ProductColor
set QuantityInStock = 0
where ColorName = 'Silver' and ProductID = 1

select * from ProductColor where ProductID = 1

insert into Product values(1, 1, 'iPhone 6s Plus 16GB', 500, 910, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(2, 'LED-backlit IPS LCD, 5.5", Retina HD', 'iOS 9', 5, 12, 'Apple A9 2 cores 64-bit, 1.8 GHz', '2GB', 'No support', '1 Nano SIM', 'WiFi, 3G, 4G LTE Cat 6', '2750 mAh', '16GB', 192)
insert into ProductColor values(2, 'Silver', 100)
insert into ProductColor values(2, 'Gray', 100)
insert into ProductColor values(2, 'Pink Gold', 100)
insert into ProductImage values(2,'https://cdn4.tgdd.vn/Products/Images/42/73704/iphone-6s-plus-64gb-bac-org-1.png')
insert into ProductImage values(2,'https://cdn2.tgdd.vn/Products/Images/42/73704/iphone-6s-plus-64gb-xam-org-1.png')
insert into ProductImage values(2,'https://cdn2.tgdd.vn/Products/Images/42/73704/iphone-6s-plus-64gb-vang-hong-org-1.png')

insert into Product values(1, 1, 'iPhone 6 Plus 64GB', 450, 830, convert(datetime, '4-8-2016 00:00:00'))
insert into ProductDetail values(3, 'LED-backlit IPS LCD, 5.5", Retina HD', 'iOS 9', 1.2, 8, 'Apple A8 2 cores 64-bit, 1.4 GHz', '1GB', 'No support', '1 Nano SIM', 'WiFi, 3G, 4G LTE Cat 4', '2915 mAh', '64GB', 192)
insert into ProductColor values(3, 'Silver', 100)
insert into ProductColor values(3, 'Gray', 100)
insert into ProductImage values(3,'https://cdn2.tgdd.vn/Products/Images/42/70259/iphone-6-plus-64gb-bac-org-1.png')
insert into ProductImage values(3,'https://cdn2.tgdd.vn/Products/Images/42/70259/iphone-6-plus-64gb-xam-org-dam.png')

insert into Product values(1, 2, 'Samsung Galaxy S7 Edge', 450, 830, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(4, 'Super AMOLED, 5.5", Quad HD', 'Android 6.0 (Marshmallow)', 5, 12, 'Exynos 8890 8 cores 64-bit, 4 cores 2.3 GHz v� 4 cores 1.6 GHz', '4GB', 'MicroSD, 200 GB', '2 Nano SIM', 'WiFi, 3G, 4G LTE Cat 9', '3600 mAh', '32GB', 157)
insert into ProductColor values(4, 'Silver', 100)
insert into ProductColor values(4, 'Black', 100)
insert into ProductColor values(4, 'Bronze Gold', 100)
insert into ProductImage values(4,'https://cdn4.tgdd.vn/Products/Images/42/75180/samsung-galaxy-s7-edge-bac-org-1.png')
insert into ProductImage values(4,'https://cdn2.tgdd.vn/Products/Images/42/75180/samsung-galaxy-s7-edge-den-org-1.png')
insert into ProductImage values(4,'https://cdn2.tgdd.vn/Products/Images/42/75180/samsung-galaxy-s7-edge-vang-dong-org-121.png')

insert into Product values(1, 2, 'Samsung Galaxy S7', 400, 700, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(5, 'Super AMOLED, 5.5", Quad HD', 'Android 6.0 (Marshmallow)', 5, 12, 'Exynos 8890 8 cores 64-bit, 4 cores 2.3 GHz v� 4 cores 1.6 GHz', '4GB', 'MicroSD, 200 GB', '2 Nano SIM', 'WiFi, 3G, 4G LTE Cat 9', '3600 mAh', '32GB', 157)
insert into ProductColor values(5, 'Silver', 100)
insert into ProductColor values(5, 'Black', 100)
insert into ProductColor values(5, 'Bronze Gold', 100)
insert into ProductImage values(5,'https://cdn4.tgdd.vn/Products/Images/42/74113/samsung-galaxy-s7-bac-org-1.png')
insert into ProductImage values(5,'https://cdn4.tgdd.vn/Products/Images/42/74113/samsung-galaxy-s7-den-org-1.png')
insert into ProductImage values(5,'https://cdn2.tgdd.vn/Products/Images/42/74113/samsung-galaxy-s7-vang-dong-org-1.png')

insert into Product values(1, 2, 'Samsung Galaxy A7', 100, 300, convert(datetime, '4-8-2016 00:00:00'))
insert into ProductDetail values(6, 'Super AMOLED, 5.5", Quad HD', 'Android 5.0 (Lolipop)', 5, 12, 'Snapdragon 615 8 cores 64-bit, Quad-core 1.5 GHz + Quad-core 1 GHz', '2GB', 'MicroSD, 64 GB', '2 Nano SIM', 'WiFi, 3G', '2600 mAh', '16GB', 157)
insert into ProductColor values(6, 'Bronze Gold', 100)
insert into ProductImage values(6,'https://cdn2.tgdd.vn/Products/Images/42/70761/samsung-galaxy-a7-gold-org-1.png')

insert into Product values(1, 3, 'Sony Xperia Z5 Premium Dual', 400, 700, convert(datetime, '4-8-2016 00:00:00'))
insert into ProductDetail values(7, 'IPS LCD, 5.5", Ultra HD', 'Android 6.0 (Marshmallow)', 5, 23, 'Snapdragon 810 8 cores 64-bit, 4 cores 1.5 GHz Cortex-A53 & 4 cores 2 GHz Cortex-A57', '3GB', 'MicroSD, 200 GB', '2 Nano SIM', 'WiFi, 3G, 4G LTE Cat 4', '3430 mAh', '32GB', 157)
insert into ProductColor values(7, 'Bronze Gold', 100)
insert into ProductColor values(7, 'Silver Inox', 100)	
insert into ProductImage values(7,'https://cdn4.tgdd.vn/Products/Images/42/73023/sony-xperia-z5-premium-vang-dong-org-1.png')
insert into ProductImage values(7,'https://cdn4.tgdd.vn/Products/Images/42/73023/sony-xperia-z5-premium-bac-2-org-1.png')

insert into Product values(1, 3, 'Sony Xperia Z5 Dual', 300, 600, convert(datetime, '4-8-2016 00:00:00'))
insert into ProductDetail values(8, 'IPS LCD, 5.2", Ultra HD', 'Android 6.0 (Marshmallow)', 5, 23, 'Snapdragon 810 8 cores 64-bit, 4 cores 1.5 GHz Cortex-A53 & 4 cores 2 GHz Cortex-A57', '3GB', 'MicroSD, 200 GB', '2 Nano SIM', 'WiFi, 3G, 4G LTE Cat 6', '2900 mAh', '32GB', 157)
insert into ProductColor values(8, 'Black', 100)
insert into ProductColor values(8, 'Bronze Gold', 100)
insert into ProductColor values(8, 'White', 100)	
insert into ProductImage values(8,'https://cdn2.tgdd.vn/Products/Images/42/73021/sony-xperia-z5-den-org-1.png')
insert into ProductImage values(8,'https://cdn4.tgdd.vn/Products/Images/42/73021/sony-xperia-z5-trang-org-1.png')
insert into ProductImage values(8,'https://cdn2.tgdd.vn/Products/Images/42/73021/sony-xperia-z5-vang-dong-org-1.png')

insert into Product values(1, 3, 'Sony Xperia XA', 100, 270, convert(datetime, '4-8-2016 00:00:00'))
insert into ProductDetail values(9, 'IPS LCD, 5", HD', 'Android 6.0 (Marshmallow)', 8, 15, 'Helio P10 8 cores 64-bit, 2.0 GHz', '2GB', 'MicroSD, 200 GB', '2 Nano SIM', 'WiFi, 3G, 4G LTE Cat 4', '2300 mAh', '16GB', 157)
insert into ProductColor values(9, 'Black', 100)
insert into ProductColor values(9, 'Bronze Gold', 100)
insert into ProductColor values(9, 'White', 100)	
insert into ProductImage values(9,'https://cdn4.tgdd.vn/Products/Images/42/75245/sony-xperia-xa-org-den.png')
insert into ProductImage values(9,'https://cdn2.tgdd.vn/Products/Images/42/75245/sony-xperia-xa-org-trang.png')
insert into ProductImage values(9,'https://cdn4.tgdd.vn/Products/Images/42/75245/sony-xperia-xa-vang-org-dong.png')

insert into Product values(1, 4, 'HTC 10', 400, 760, convert(datetime, '4-8-2016 00:00:00'))
insert into ProductDetail values(10, 'Super LCD 5, 5.2", Quad HD', 'Android 6.0 (Marshmallow)', 5, 12, 'Snapdragon 820 4 cores 64-bit, 2.2 GHz', '4GB', 'MicroSD, 200 GB', '1 Nano SIM', 'WiFi, 3G, 4G LTE Cat 9', '2300 mAh', '32GB', 157)
insert into ProductColor values(10, 'Silver', 100)
insert into ProductImage values(10,'https://cdn.tgdd.vn/Products/Images/42/74927/htc-102-400x460.png')

insert into Product values(1, 4, 'HTC One A9', 200, 400, convert(datetime, '4-8-2016 00:00:00'))
insert into ProductDetail values(11, 'AMOLED, 5", HD', 'Android 6.0 (Marshmallow)', 4, 15, 'Qualcomm Snapdragon 617 8 cores 64-bit, 4 cores 1.5 GHz Cortex-A53 & 4 cores 1.2 GHz Cortex-A53', '2GB', 'MicroSD, 200 GB', '1 Nano SIM', 'WiFi, 3G, 4G LTE Cat 4', '2150 mAh', '16GB', 157)
insert into ProductColor values(11, 'Siver', 100)
insert into ProductColor values(11, 'Bronze Gold', 100)
insert into ProductColor values(11, 'Gray', 100)	
insert into ProductImage values(11,'https://cdn4.tgdd.vn/Products/Images/42/73268/htc-one-a9-org-bac.png')
insert into ProductImage values(11,'https://cdn4.tgdd.vn/Products/Images/42/73268/htc-one-a9-org-xam.png')
insert into ProductImage values(11,'https://cdn2.tgdd.vn/Products/Images/42/73268/htc-one-a9-vang-org-dong.png')

insert into Product values(1, 5, 'Asus Zenfone 3 ZE552KL', 200, 400, convert(datetime, '4-8-2016 00:00:00'))
insert into ProductDetail values(12, 'Super IPS LCD, 5.5", Full HD', 'Android 6.0 (Marshmallow)', 8, 16, 'Snapdragon 625 8 cores 64-bit, 2.0 GHz', '4GB', 'MicroSD, 128 GB', '2 Nano SIM', 'WiFi, 3G, 4G LTE Cat 4', '3000 mAh', '64GB', 157)
insert into ProductColor values(12, 'Black', 100)
insert into ProductColor values(12, 'White', 100)	
insert into ProductImage values(12,'https://cdn.tgdd.vn/Products/Images/42/75994/asus-zenfone-3-ze552kl-400-400x460.png')

insert into Product values(1, 5, 'Asus Zenfone 3 ZE520KL', 100, 350, convert(datetime, '4-8-2016 00:00:00'))
insert into ProductDetail values(13, 'Super IPS LCD, 5.2", Full HD', 'Android 6.0 (Marshmallow)', 8, 16, 'Snapdragon 625 8 cores 64-bit, 2.0 GHz', '4GB', 'MicroSD, 128 GB', '2 Nano SIM', 'WiFi, 3G, 4G LTE Cat 4', '2650 mAh', '64GB', 157)
insert into ProductColor values(13, 'Black', 100)
insert into ProductColor values(13, 'White', 100)	
insert into ProductImage values(13,'https://cdn.tgdd.vn/Products/Images/42/79952/asus-zenfone-3-ze520kl-400-400x460.png')

insert into Product values(1, 6, 'LG Stylus 2', 100, 200, convert(datetime, '4-8-2016 00:00:00'))
insert into ProductDetail values(14, 'IPS LCD, 5.7", HD', 'Android 6.0 (Marshmallow)', 8, 15, 'Qualcomm Snapdragon 410 4 cores	 64-bit, 1.2 GHz', '2GB', 'MicroSD, 128 GB', '2 Nano SIM', 'WiFi, 3G, 4G LTE Cat 4', '3000 mAh', '16GB', 157)
insert into ProductColor values(14, 'Brown', 100)
insert into ProductColor values(14, 'White', 100)	
insert into ProductImage values(14,'https://cdn.tgdd.vn/Products/Images/42/75205/lg-stylus-2-1-400x460.png')

insert into Product values(1, 7, 'Pantech V955', 100, 200, convert(datetime, '4-8-2016 00:00:00'))
insert into ProductDetail values(15, 'IPS LCD, 5.5", HD', 'Android 5.0 (Lollipop)', 5, 15, 'Snapdragon 415 8 nh�n, 1.4 GHz', '2GB', 'MicroSD, 128 GB', '2 Nano SIM', 'WiFi, 3G, 4G LTE Cat 4', '2500 mAh', '16GB', 157)
insert into ProductColor values(15, 'Black', 100)
insert into ProductColor values(15, 'White', 100)	
insert into ProductImage values(15,'https://cdn.tgdd.vn/Products/Images/42/79206/pantech-v955-400-400x460.png')

insert into Product values(2, 1, 'iPad Pro Wifi Cellular 128GB', 700, 1210, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(16, 'LED-backlit LCD 12.9"', 'iOS 9', 5, 8, 'Apple A9 2 cores 64-bit, 2.2 GHz', '4GB', 'No support', '1 Nano SIM', 'WiFi, 3G, 4G LTE Cat 6', '10300 mAh', '128GB', 713)
insert into ProductColor values(16, 'Silver', 100)
insert into ProductColor values(16, 'Gray', 100)
insert into ProductColor values(16, 'Bronze Gold', 100)
insert into ProductImage values(16,'https://cdn4.tgdd.vn/Products/Images/522/73989/ipad-pro-wifi-cellular-128gb-bac-org-1.png')
insert into ProductImage values(16,'https://cdn2.tgdd.vn/Products/Images/522/73989/ipad-pro-wifi-cellular-128gb-xam-org-1.png')
insert into ProductImage values(16,'https://cdn2.tgdd.vn/Products/Images/522/73989/ipad-pro-wifi-cellular-128gb-vang-dong-org-1.png')

insert into Product values(2, 1, 'iPad Pro Wifi 32GB', 500, 900, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(17, 'LED-backlit LCD 12.9"', 'iOS 9', 5, 8, 'Apple A9 2 cores 64-bit, 2.2 GHz', '4GB', 'No support', '1 Nano SIM', 'WiFi, 3G, 4G LTE Cat 6', '10300 mAh', '32GB', 713)
insert into ProductColor values(17, 'Silver', 100)
insert into ProductColor values(17, 'Gray', 100)
insert into ProductColor values(17, 'Bronze Gold', 100)
insert into ProductImage values(17,'https://cdn.tgdd.vn/Products/Images/522/73088/ipad-pro-wifi-32gb-400x460.png')

insert into Product values(2, 1, 'iPad Pro 9.7 inch Wifi 128GB', 400, 850, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(18, 'LED-backlit LCD 9.7"', 'iOS 9', 5, 8, 'Apple A9 2 cores 64-bit, 2.2 GHz', '2GB', 'No support', 'No support', 'WiFi', '7350 mAh', '128GB', 713)
insert into ProductColor values(18, 'Pink Gold', 100)
insert into ProductColor values(18, 'Bronze Gold', 100)
insert into ProductImage values(18,'https://cdn4.tgdd.vn/Products/Images/522/76976/ipad-pro-97-inch-wifi-128gb-vang-dong-org-1.png')
insert into ProductImage values(18,'https://cdn4.tgdd.vn/Products/Images/522/76976/ipad-pro-97-inch-wifi-128gb-vang-hong-org-1.png')

insert into Product values(2, 2, 'Samsung Galaxy Tab S2 8', 200, 450, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(19, 'Super AMOLED, 8"', 'Android 5.0', 5, 8, 'Exynos 5433, 1.3 GHz Cortex-A53 & 1.9 GHz Cortex-A57', '3GB', 'No support', 'Nano SIM', 'WiFi', '7350 mAh', '32GB', 713)
insert into ProductColor values(19, 'Black', 100)
insert into ProductColor values(19, 'White', 100)
insert into ProductImage values(19,'https://cdn4.tgdd.vn/Products/Images/522/72479/samsung-galaxy-tab-s2-84-den-org-1.png')
insert into ProductImage values(19,'https://cdn2.tgdd.vn/Products/Images/522/72479/samsung-galaxy-tab-s2-84-trang-org-1.png')

insert into Product values(2, 2, 'Samsung Galaxy Tab A6 10.1 (2016)', 100, 350, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(20, 'Super AMOLED, 8"', 'Android 6.0', 5, 8, 'Exynos 7870, 1.6 GHz', '3GB', 'No support', 'Nano SIM', 'WiFi, 3G, LTE Cat 4', '7350 mAh', '32GB', 713)
insert into ProductColor values(20, 'Black', 100)
insert into ProductColor values(20, 'White', 100)
insert into ProductImage values(20,'https://cdn4.tgdd.vn/Products/Images/522/77615/samsung-galaxy-tab-a-101-2016-den-org-1.png')
insert into ProductImage values(20,'https://cdn4.tgdd.vn/Products/Images/522/77615/samsung-galaxy-tab-a-101-2016-org-trang.png')

insert into Product values(2, 2, 'Samsung Galaxy Tab A 9.7', 100, 300, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(21, 'Super AMOLED, 8"', 'Android 6.0', 5, 8, 'Qualcomm Snapdragon 410 4 cores, 1.2 GHz', '3GB', 'No support', 'Nano SIM', 'WiFi, 3G, LTE Cat 4', '7350 mAh', '32GB', 713)
insert into ProductColor values(21, 'Black', 100)
insert into ProductColor values(21, 'White', 100)
insert into ProductImage values(21,'https://cdn.tgdd.vn/Products/Images/522/71221/samsung-galaxy-tab-a-plus-97-sm-p555-533but-3-400x533.png')

insert into Product values(2, 2, 'Samsung Galaxy Tab A6 7.0', 100, 150, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(22, 'Super AMOLED, 8"', 'Android 6.0', 5, 8, 'Qualcomm Snapdragon 410 4 cores, 1.2 GHz', '3GB', 'No support', 'Nano SIM', 'WiFi, 3G, LTE Cat 4', '7350 mAh', '8GB', 713)
insert into ProductColor values(22, 'Black', 100)
insert into ProductColor values(22, 'White', 100)
insert into ProductImage values(22,'https://cdn.tgdd.vn/Products/Images/522/75693/samsung-galaxy-tab-a-70-1-400x460.png')

insert into Product values(2, 1, 'iPad Pro 9.7 inch Wifi 32GB', 400, 700, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(23, 'LED-backlit LCD 9.7"', 'iOS 9', 5, 8, 'Apple A9 2 cores 64-bit, 2.2 GHz', '2GB', 'No support', 'No support', 'WiFi', '7350 mAh', '32GB', 713)
insert into ProductColor values(23, 'Pink Gold', 100)
insert into ProductColor values(23, 'Bronze Gold', 100)
insert into ProductColor values(23, 'Silver', 100)
insert into ProductImage values(23,'https://cdn4.tgdd.vn/Products/Images/522/75490/ipad-pro-97-inch-bac-org-1.png')
insert into ProductImage values(23,'https://cdn2.tgdd.vn/Products/Images/522/75490/ipad-pro-97-inch-vang-dong-org-1.png')
insert into ProductImage values(23,'https://cdn2.tgdd.vn/Products/Images/522/75490/ipad-pro-97-inch-vang-hong-org-1.png')

insert into Product values(3, 1, 'Apple Macbook Air MJVM2ZP/A', 500, 1000, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(24, '11.6 inch, HD (1366 x 768 pixels)', 'Mac OS', 2, null, 'Intel Core i5 Broadwell 5250U 1.60 GHz', '4GB', 'SD', 'No support', 'WiFi 802.11a/b/g/n Bluetooth v4.0', 'Lithium- polymer', 'SSD, 128 GB', 2)
insert into ProductColor values(24, 'Silver', 100)
insert into ProductImage values(24,'https://cdn.tgdd.vn/Products/Images/44/71277/apple-macbook-air-2015-mjvm2zp-a-i5-5250u-4gb-128g-1-121111-400x400.png')

insert into Product values(3, 1, 'Apple Macbook Air MMGG2ZP/A', 500, 1300, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(25, '13.3 inch, HD (1366 x 768 pixels)', 'Mac OS', 2, null, 'Intel, Core i5 Broadwell, 5250U, 1.60 GHz', '8GB', 'SDXC', 'No support', 'WiFi 802.11a/b/g/n Bluetooth v4.0', 'Lithium- polymer', 'SSD 256 GB', 2)
insert into ProductColor values(25, 'Silver', 100)
insert into ProductImage values(25,'https://cdn.tgdd.vn/Products/Images/44/80468/apple-macbook-air-2015-mmgg2zp-a-i5-5250u-8gb-256g-400-400x400.png')

insert into Product values(3, 1, 'Apple Macbook 12" MMGM2', 500, 1700, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(26, '12 inch, HD (2304 x 1440 pixels)', 'Mac OS', 2, null, 'Intel, Core M, 1.20 GHz', '8GB', 'SDXC', 'No support', 'WiFi 802.11a/b/g/n Bluetooth v4.0', 'Lithium- polymer', 'SSD 512 GB', 2)
insert into ProductColor values(26, 'Pink', 100)
insert into ProductImage values(26,'https://cdn.tgdd.vn/Products/Images/44/80731/apple-macbook-12-mmgm2-core-m-12g-8gb-512gb-macos-1-400x450.png')


insert into Product values(3, 8, 'Dell Inspiron 3552', 100, 300, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(27, '15.6 inch, HD (1366 x 768 pixels)', 'Windows 10', 2, null, 'Intel, Celeron, N3050, 1.60 GHz', '2GB', 'SDXC', 'No support', 'WiFi 802.11a/b/g/n Bluetooth v4.0', 'Lithium- polymer', 'HDD, 500 GB', 2)
insert into ProductColor values(27, 'Black', 100)
insert into ProductImage values(27,'https://cdn.tgdd.vn/Products/Images/44/74357/dell-inspiron-3552-n3050-2gb-500gb-win10-400-1-400x313.png')

insert into Product values(3, 8, 'Dell Inspiron 3558', 100, 500, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(28, '15.6 inch, HD (1366 x 768 pixels)', 'Windows 10', 2, null, 'Intel, Core i3 Broadwell, 5005U, 2.00 GHz', '4GB', 'SDXC', 'No support', 'WiFi 802.11a/b/g/n Bluetooth v4.0', 'Lithium- polymer', 'HDD, 500 GB', 2)
insert into ProductColor values(28, 'Black', 100)
insert into ProductImage values(28,'https://cdn.tgdd.vn/Products/Images/44/77734/dell-inspiron-3558-i3-5005u-4gb-500gb-win10-khongd-400-400x400.png')

insert into Product values(3, 8, 'Dell Inspiron 5458', 100, 500, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(29, '14 inch, HD (1366 x 768 pixels)', 'Windows 10', 2, null, 'Intel, Core i3 Broadwell, 5005U, 2.00 GHz', '4GB', 'SDXC', 'No support', 'WiFi 802.11a/b/g/n Bluetooth v4.0', 'Lithium- polymer', 'HDD, 500 GB', 2)
insert into ProductColor values(29, 'Black', 100)
insert into ProductImage values(29,'https://cdn.tgdd.vn/Products/Images/44/75106/dell-inspiron-5458-i3-5005u-4gb-500gb-win10-office-400-400x400.png')

insert into Product values(3, 9, 'HP Pavilion 11 S001TU', 100, 300, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(30, '11.6 inch, HD (1366 x 768 pixels)', 'Windows 10', 2, null, 'Intel, Celeron, N3050, 1.60 GHz', '2GB', 'SDXC', 'No support', 'WiFi 802.11a/b/g/n Bluetooth v4.0', 'Lithium- polymer', 'HDD, 500 GB', 2)
insert into ProductColor values(30, 'Black', 100)
insert into ProductImage values(30,'https://cdn2.tgdd.vn/Products/Images/44/75890/Slider/hp-pavilion-11-s001tu-n3050-2gb-500gb-win10-den-slider1a.jpg')

insert into Product values(3, 9, 'HP 14 am048TU', 100, 300, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(31, '14 inch, HD (1366 x 768 pixels)', 'Windows 10', 2, null, 'Intel, Pentium, N3710, 1.60 GHz', '4GB', 'SDXC', 'No support', 'WiFi 802.11a/b/g/n Bluetooth v4.0', 'Lithium- polymer', 'HDD, 500 GB', 2)
insert into ProductColor values(31, 'Black', 100)
insert into ProductImage values(31,'https://cdn1.tgdd.vn/Products/Images/44/83290/Slider/slider1.jpg')

insert into Product values(3, 9, 'HP Pavilion x360', 100, 500, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(32, '11 inch, HD (1366 x 768 pixels)', 'Windows 10', 2, null, 'Intel, Core M, M3-6Y30, 900 MHz', '4GB', 'SDXC', 'No support', 'WiFi 802.11a/b/g/n Bluetooth v4.0', 'Lithium- polymer', 'HDD, 500 GB', 2)
insert into ProductColor values(32, 'Black', 100)
insert into ProductImage values(32,'https://cdn.tgdd.vn/Products/Images/44/75909/hp-pavilion-x360-k118tu-m3-6y30-4gb-500gb-win10-400-400x400.png')

insert into Product values(3, 10, 'Acer ES1 531', 100, 300, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(33, '15.6 inch, HD (1366 x 768 pixels)', 'Windows 10', 2, null, 'Intel, Pentium, N3710, 1.60 GHz', '4GB', 'SDXC', 'No support', 'WiFi 802.11a/b/g/n Bluetooth v4.0', 'Lithium- polymer', 'HDD, 500 GB', 2)
insert into ProductColor values(33, 'Black', 100)
insert into ProductImage values(33,'https://cdn.tgdd.vn/Products/Images/44/82541/acer-es1-531-n3710-4gb-500gb-win10-400-400x400.png')

insert into Product values(3, 10, 'Acer Aspire E5 575', 100, 400, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(34, '15.6 inch, HD (1366 x 768 pixels)', 'Windows 10', 2, null, 'Intel, Core i3 Skylake, 6100U, 2.30 GHz', '4GB', 'SDXC', 'No support', 'WiFi 802.11a/b/g/n Bluetooth v4.0', 'Lithium- polymer', 'HDD, 500 GB', 2)
insert into ProductColor values(34, 'Black', 100)
insert into ProductImage values(34,'https://cdn.tgdd.vn/Products/Images/44/82992/acer-aspire-e5-575-320a-i3-6100u-4gb-500gb-win10-400-400x400.png')

insert into Product values(3, 10, 'Acer V3 574', 100, 500, convert(datetime, '4-9-2016 00:00:00'))
insert into ProductDetail values(35, '15.6 inch, HD (1920 x 1080 pixels)', 'Windows 10', 2, null, 'Intel, Core i3 Skylake, 6100U, 2.30 GHz', '4GB', 'SDXC', 'No support', 'WiFi 802.11a/b/g/n Bluetooth v4.0', 'Lithium- polymer', 'HDD, 500 GB', 2)
insert into ProductColor values(35, 'Black', 100)
insert into ProductImage values(35,'https://cdn.tgdd.vn/Products/Images/44/77490/acer-v3-574-i3-5005u-4gb-500gb-win10-400x400.png')

select * from Comment
delete Comment

select * from [User]

insert into Comment values(7, 1, 'Comment 1', convert(datetime, '10-4-2016 00:00:00'))
insert into Comment values(7, 1, 'Comment 2', convert(datetime, '10-4-2016 00:00:00'))
insert into Comment values(7, 1, 'Comment 3', convert(datetime, '10-4-2016 00:00:00'))
insert into Comment values(7, 1, 'Comment 4', convert(datetime, '10-4-2016 00:00:00'))
insert into Comment values(7, 1, 'Comment 5', convert(datetime, '10-4-2016 00:00:00'))

insert into Comment values(7, 1, 'Comment 6', convert(datetime, '10-4-2016 00:00:00'))
insert into Comment values(7, 1, 'Comment 7', convert(datetime, '10-4-2016 00:00:00'))
insert into Comment values(7, 1, 'Comment 8', convert(datetime, '10-4-2016 00:00:00'))
insert into Comment values(7, 1, 'Comment 9', convert(datetime, '10-4-2016 00:00:00'))
insert into Comment values(7, 1, 'Comment 10', convert(datetime, '10-4-2016 00:00:00'))

insert into Comment values(7, 1, 'Comment 11', convert(datetime, '10-4-2016 00:00:00'))

insert into Comment values(7, 1, 'Comment 12', convert(datetime, '10-4-2016 00:00:00'))

insert into Comment values(7, 1, 'This is a comment', convert(date, '12-10-2016'))


select * from ProductImage
select * from Product

SELECT        ManufacturerName
FROM            Category INNER JOIN
                         Product ON Category.CategoryID = Product.CategoryID INNER JOIN
                         Manufacturer ON Product.ManufacturerID = Manufacturer.ManufacturerID
						 where Category.CategoryID = 1
						 group by ManufacturerName

create procedure GetManufactureList(
	@id int
)
as
begin
SELECT        Manufacturer.ManufacturerID, ManufacturerName
FROM            Category INNER JOIN
                         Product ON Category.CategoryID = Product.CategoryID INNER JOIN
                         Manufacturer ON Product.ManufacturerID = Manufacturer.ManufacturerID
						 where Category.CategoryID = @id
						 group by Manufacturer.ManufacturerID, ManufacturerName
end

drop procedure GetManufactureList

exec GetManufactureList 1

exec GetManufactureList 2

exec GetManufactureList 3

select * from Product where ProductName = 'Sony Xperia XA'

select * from ProductColor where ProductID = 6

select * from ProductColor where ProductID = 9

	
