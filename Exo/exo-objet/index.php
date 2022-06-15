<?php
include 'BankAccount.php';



$client1 = new BankAccount('mathilde','maBank',353512345678985256,'livret A');


$client1->_credit(2000);
$client1->_getBalance();
$client1->_debit(800);
$client1->_getBalance();
$client1->_debit(800);
$client1->_getBalance();
$client1->_debit(800);
$client1->_getBalance();
$client1->_debit(800);
$client1->_getBalance();
$client1->_debit(800);
$client1->_getBalance();

?>