@echo off
title Neighbor
color 3f

rem Deprecated : �@��L�ΰT��
echo ===== ARP �C�� =====
arp -a
echo.

echo ===== NDP �C�� =====
netsh interface ipv6 show neighbors
pause