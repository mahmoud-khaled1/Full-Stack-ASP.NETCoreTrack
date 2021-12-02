<?php

if(isset($_POST['name'])){
    echo `Hello `.$_POST['name'] . 'Your Last Login At ' . $_POST['lastlogin'];
}