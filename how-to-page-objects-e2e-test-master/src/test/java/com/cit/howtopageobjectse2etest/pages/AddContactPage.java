package com.cit.howtopageobjectse2etest.pages;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.Select;

public class AddContactPage extends BasePage  {
    public AddContactPage(WebDriver navegador){super(navegador);}


    public AddContactPage editType(){
        navegador.findElement(By.xpath("/html/body/div[2]/div[1]")).findElement(By.name("type")).sendKeys("Phone");
        return this;
    }

    public AddContactPage editNumber(){
        navegador.findElement(By.xpath("/html/body/div[2]/div[1]")).findElement(By.name("contact")).sendKeys("+55119999999");
        return this;
    }

    public String buttonFinished(){
        navegador.findElement(By.xpath("/html/body/div[2]/div[2]/a")).click();
        String result = this.navegador.findElement(By.className("toast")).getText();
        return result;
    }
}
