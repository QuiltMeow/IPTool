@echo off
title Neighbor
color 3f

rem Deprecated : 一堆無用訊息
echo ===== ARP 列表 =====
arp -a
echo.

echo ===== NDP 列表 =====
netsh interface ipv6 show neighbors
pause