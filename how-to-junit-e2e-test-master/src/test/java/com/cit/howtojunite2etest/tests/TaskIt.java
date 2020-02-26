package com.cit.howtojunite2etest.tests;

import com.cit.howtojunite2etest.suporte.Navegador;
import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.*;
import org.openqa.selenium.interactions.Actions;

public class TaskIt {
    private WebDriver navegador;

    @Before
    public void before () {
        this.navegador = Navegador.criarNavegador();
    }

    /* url da página de teste: http://www.juliodelima.com.br/taskit */
    @Test
    public void testAdicionarUmaInformacaoAdicionalDoUsuario () throws InterruptedException {

        this.navegador.get("http://www.juliodelima.com.br/taskit/");
        // Mudar o foco para a modal de Login
        this.navegador.findElement(By.xpath("/html/body/nav/div/div/ul[1]/li/a")).click();

        // Digitar no campo "login" (dentro do formulário) o texto "julio0001"


        // Digitar no campo "password" (dentro do formulário) o texto "123456"


        // Clicar no link "SIGN IN"

        WebElement modal = this.navegador.findElement(By.id("signinbox"));
        modal.findElement(By.name("login")).sendKeys("julio0001");
        modal.findElement(By.name("password")).sendKeys("123456");


        this.navegador.findElement(By.linkText("SIGN IN")).click();



        // Clicar no no link "me"
        this.navegador.findElement(By.className("me")).click();
        Thread.sleep(1000);
        // Clicar no link  "MORE DATA ABOUT YOU"
        this.navegador.findElement(By.xpath("/html/body/div[1]/div/div/div/div[1]/ul/li[3]/a")).click();
        // Clicar no botão "+ ADD MORE DATA"
        this.navegador.findElement(By.xpath("/html/body/div[1]/div/div/div/div[4]/div[2]/button")).click();

        // Mudar o foco para a modal de formulário para adicionar mais dados

        // Escolher a opção Phone no combobox de type
        this.navegador.findElement(By.xpath("/html/body/div[2]/div[1]/div[2]/select")).sendKeys("Phone");
        // No campo de "contact" digitar "+5511999999999"
        this.navegador.findElement(By.xpath("/html/body/div[2]/div[1]/div[3]/div/input")).sendKeys("+5511999999999");
        // Clicar no link "SAVE" que está na popup
        Thread.sleep(1000);
        this.navegador.findElement(By.xpath("/html/body/div[2]/div[2]/a")).click();
        Thread.sleep(1000);
        // Na mensagem validar que o texto é "Your contact has been added!"
        String result = this.navegador.findElement(By.xpath("//div[@id='toast-container']/div")).getText();

        Assert.assertEquals("Your contact has been added!", result);
    }

    @After
    public void after () {
        this.navegador.quit();
    }
}
