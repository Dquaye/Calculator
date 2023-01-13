using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Calculator : MonoBehaviour
{
       
    public Text answer, history, tempanswer, txtdisplay;
    
    int operations = 0;
    int counter = 0;
    bool selector = false;
    double firstnum, secondnum, sum, difference, product, quotient, a, b;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void btn1_Click()
    {
        if (txtdisplay.text != "0")
        {
            txtdisplay.text += "1";
        }
        else { txtdisplay.text = "1"; }

    }

    public void btn2_Click()
    {
        if (txtdisplay.text != "0")
        {
            txtdisplay.text += "2";
        }
        else { txtdisplay.text = "2"; }
    }

    public void btn3_Click()
    {
        if (txtdisplay.text != "0")
        {
            txtdisplay.text += "3";
        }
        else { txtdisplay.text = "3"; }
    }

    public void btn4_Click()
    {
        if (txtdisplay.text != "0")
        {
            txtdisplay.text += "4";
        }
        else { txtdisplay.text = "4"; }
    }

    public void btn5_Click()
    {
        if (txtdisplay.text != "0")
        {
            txtdisplay.text += "5";
        }
        else { txtdisplay.text = "5"; }
    }
    public void btn6_Click()
    {
        if (txtdisplay.text != "0")
        {
            txtdisplay.text += "6";
        }
        else { txtdisplay.text = "6"; }
    }

    public void btn7_Click()
    {
        if (txtdisplay.text != "0")
        {
            txtdisplay.text += "7";
        }
        else { txtdisplay.text = "7"; }
    }

    public void btn8_Click()
    {
        if (txtdisplay.text != "0")
        {
            txtdisplay.text += "8";
        }
        else { txtdisplay.text = "8"; }
    }

    public void btn9_Click()
    {
        if (txtdisplay.text != "0")
        {
            txtdisplay.text += "9";
        }
        else { txtdisplay.text = "9"; }
    }
    public void btn0_Click()
    {
        if (txtdisplay.text != "0")
        {
            txtdisplay.text += "0";
        }

    }
    public void btnpoint_Click()
    {
        if (!txtdisplay.text.Contains("."))
        {
            txtdisplay.text += ".";
        }
    }

    public void btnadd_Click()
    {
        if (history.text =="")
        {
            history.text = txtdisplay.text+" +";
        }
        else if (history.text != "" && !history.text.Contains("="))
        {
            history.text = history.text  + txtdisplay.text +" +";
        }
        else if  (history.text.Contains("="))
        {
            history.text = answer.text + " + ";
        }
        
        if (operations == 2)
        {
            a = firstnum;
            b = Convert.ToDouble(txtdisplay.text);
            difference = a - b;
            firstnum = difference;
            answer.text = Convert.ToString(difference);
            tempanswer.text = Convert.ToString(difference);
            counter = 0;



        }
        if (operations == 3)
        {
            a = firstnum;
            b = Convert.ToDouble(txtdisplay.text);
            product = a * b;
            firstnum = product;
            answer.text = Convert.ToString(product);
            tempanswer.text = Convert.ToString(product);
            counter = 0;



        }
        if (operations == 4)
        {
            a = firstnum;
            b = Convert.ToDouble(txtdisplay.text);
            quotient = a / b;
            firstnum = quotient;
            answer.text = Convert.ToString(quotient);
            tempanswer.text = Convert.ToString(quotient);
            counter = 0;



        }
        if (selector == false)
        {
            if (counter == 0)
            {
                
                firstnum = Convert.ToDouble(txtdisplay.text);
                txtdisplay.text = "0";
                selector = true;
                operations = 1;
                
            }
            if (counter > 0)
            {
                secondnum = Convert.ToDouble(txtdisplay.text);

                sum = firstnum + secondnum;
                firstnum = sum;
                answer.text = Convert.ToString(firstnum);
                tempanswer.text = Convert.ToString(firstnum);
                txtdisplay.text = "0";
                selector = true;
                operations = 1;
            }

            counter++;

        }
        else
        {
            if (counter == 0)
            {
                txtdisplay.text = "0";
                firstnum = Convert.ToDouble(answer.text);
                txtdisplay.text = "0";
                selector = true;
                operations = 1;
            }
            if (counter > 0)
            {
                secondnum = Convert.ToDouble(txtdisplay.text);
                
                sum = firstnum + secondnum;
                firstnum = sum;
                answer.text = Convert.ToString(firstnum);
                tempanswer.text = Convert.ToString(firstnum);
                txtdisplay.text = "0";
                selector = true;
                operations = 1;
            }

            counter++;
        }
    }

    public void btnsubtr_Click()
    {
        if (history.text == "")
        {
            history.text = txtdisplay.text + " -";
        }
        else if (history.text != "" && !history.text.Contains("="))
        {
            history.text = history.text + txtdisplay.text + " -";
        }
        else if (history.text.Contains("="))
        {
            history.text = answer.text + " - ";
        }
        if (operations == 1)
        {
            a = firstnum;
            b = Convert.ToDouble(txtdisplay.text);
            sum = a + b;
            firstnum = sum;
            answer.text = Convert.ToString(sum);
            tempanswer.text = Convert.ToString(sum);
            counter = 0;



        }
        if (operations == 3)
        {
            a = firstnum;
            b = Convert.ToDouble(txtdisplay.text);
            product = a * b;
            firstnum = product;
            answer.text = Convert.ToString(product);
            tempanswer.text = Convert.ToString(product);
            counter = 0;



        }
        if (operations == 4)
        {
            a = firstnum;
            b = Convert.ToDouble(txtdisplay.text);
            quotient = a / b;
            firstnum = quotient;
            answer.text = Convert.ToString(quotient);
            tempanswer.text = Convert.ToString(quotient);
            counter = 0;



        }
        if (selector == false)
        {
            if (txtdisplay.text =="" )
            {
                txtdisplay.text = "-";
            }
            else
            {
                if (counter == 0)
                {

                    firstnum = Convert.ToDouble(txtdisplay.text);
                    txtdisplay.text = "0";
                    selector = true;
                    operations = 2;
                }
                if (counter > 0)
                {


                    secondnum = Convert.ToDouble(txtdisplay.text);

                    difference = firstnum - secondnum;
                    answer.text = Convert.ToString(difference);
                    tempanswer.text = Convert.ToString(difference);
                    firstnum = difference;

                    txtdisplay.text = "0";
                    selector = true;
                    operations = 2;
                }

                counter++;
            }
            
        }
        else
        {
            if (counter == 0)
            {
                txtdisplay.text = "0";
                firstnum = Convert.ToDouble(answer.text);
                txtdisplay.text = "0";
                selector = true;
                operations = 2;
            }
            if (counter > 0)
            {


                secondnum = Convert.ToDouble(txtdisplay.text);

                difference = firstnum - secondnum;
                answer.text = Convert.ToString(difference);
                tempanswer.text = Convert.ToString(difference);
                firstnum = difference;

                txtdisplay.text = "0";
                selector = true;
                operations = 2;
            }

            counter++;
        }
    }

    public void btnmulti_Click()
    {
        if (history.text == "")
        {
            history.text = txtdisplay.text + " x";
        }
        else if (history.text != "" && !history.text.Contains("="))
        {
            history.text = history.text + txtdisplay.text + " x";
        }
        else if (history.text.Contains("="))
        {
            history.text = answer.text + " x ";
        }
        if (operations == 1)
        {
            a = firstnum;
            b = Convert.ToDouble(txtdisplay.text);
            sum = a + b;
            firstnum = sum;
            answer.text = Convert.ToString(firstnum);
            tempanswer.text = Convert.ToString(firstnum);
            counter = 0;



        }
        if (operations == 2)
        {
            a = firstnum;
            b = Convert.ToDouble(txtdisplay.text);
            difference = a - b;
            firstnum = difference;
            answer.text = Convert.ToString(difference);
            tempanswer.text = Convert.ToString(difference);
            counter = 0;



        }
        if (operations == 4)
        {
            a = firstnum;
            b = Convert.ToDouble(txtdisplay.text);
            quotient = a / b;
            firstnum = quotient;
            answer.text = Convert.ToString(quotient);
            tempanswer.text = Convert.ToString(quotient);
            counter = 0;



        }
        if (selector == false)
        {
            if (counter == 0)
            {
                firstnum = Convert.ToDouble(txtdisplay.text);
                txtdisplay.text = "0";
                selector = true;
                operations = 3;
            }
            if (counter > 0)
            {
                secondnum = Convert.ToDouble(txtdisplay.text);

                product = firstnum * secondnum;
                answer.text = Convert.ToString(product);
                tempanswer.text = Convert.ToString(product);
                firstnum = product;

                txtdisplay.text = "0";
                selector = true;
                operations = 3;
            }
            counter++;
        }
        else
        {
            if (counter == 0)
            {
                txtdisplay.text = "0";
                firstnum = Convert.ToDouble(answer.text);
                txtdisplay.text = "0";
                selector = true;
                operations = 3;
            }
            if (counter > 0)
            {
                secondnum = Convert.ToDouble(txtdisplay.text);

                product = firstnum * secondnum;
                answer.text = Convert.ToString(product);
                tempanswer.text = Convert.ToString(product);
                firstnum = product;

                txtdisplay.text = "0";
                selector = true;
                operations = 3;
            }
            counter++;
        }
    }

    public void btndivide_Click()
    {
         if (history.text =="")
         {
            history.text = txtdisplay.text+ " ÷ ";
         }
        else if (history.text != "" && !history.text.Contains("="))
        {
              history.text = history.text + txtdisplay.text + " ÷ ";
        }
        else if (history.text.Contains("="))
        {
             history.text = answer.text + " ÷ ";
        }
        if (operations == 1)
        {
            a = firstnum;
            b = Convert.ToDouble(txtdisplay.text);
            sum = a + b;
            firstnum = sum;
            answer.text = Convert.ToString(firstnum);
            tempanswer.text = Convert.ToString(firstnum);
            counter = 0;



        }
        if (operations == 3)
        {
            a = firstnum;
            b = Convert.ToDouble(txtdisplay.text);
            product = a * b;
            firstnum = product;
            answer.text = Convert.ToString(product);
            tempanswer.text = Convert.ToString(product);
            counter = 0;



        }
        if (operations == 2)
        {
            a = firstnum;
            b = Convert.ToDouble(txtdisplay.text);
            difference = a - b;
            firstnum = difference;
            answer.text = Convert.ToString(difference);
            tempanswer.text = Convert.ToString(difference);
            counter = 0;



        }
        if (selector == false)
        {
            if (counter == 0)
            {
                firstnum = Convert.ToDouble(txtdisplay.text);
                txtdisplay.text = "0";
                selector = true;
                operations = 4;
            }
            if (counter > 0)
            {
                secondnum = Convert.ToDouble(txtdisplay.text);

                quotient = firstnum / secondnum;
                answer.text = Convert.ToString(quotient);
                tempanswer.text = Convert.ToString(quotient);
                firstnum = quotient;


                txtdisplay.text = "0";
                selector = true;
                operations = 4;
            }
            counter++;
        }
        else
        {
            if (counter == 0)
            {
                txtdisplay.text = "0";
                firstnum = Convert.ToDouble(answer.text);
                txtdisplay.text = "0";
                selector = true;
                operations = 4;
            }
            if (counter > 0)
            {
                secondnum = Convert.ToDouble(txtdisplay.text);

                quotient = firstnum / secondnum;
                answer.text = Convert.ToString(quotient);
                tempanswer.text = Convert.ToString(quotient);
                firstnum = quotient;


                txtdisplay.text = "0";
                selector = true;
                operations = 4;
            }
            counter++;
        }
    }

    public void btnequal_Click()
    {
        history.text = history.text + txtdisplay.text + " " + "=";
        

        if (selector == true)
        {
            secondnum = Convert.ToDouble(txtdisplay.text);
            
        }
        if (operations == 1)
        {
            answer.text = Convert.ToString(firstnum + secondnum);


        }
        else if (operations == 2)
        {

            answer.text = Convert.ToString(firstnum - secondnum);

        }
        else if (operations == 3)
        {

            answer.text = Convert.ToString(firstnum * secondnum);

        }
        else if (operations == 4)
        {

            answer.text = Convert.ToString(firstnum / secondnum);

        }
       
            
            
        
    }

    public void btnclear_Click()
    {
        txtdisplay.text = "0";
        answer.text = " ";
        tempanswer.text = "";
        selector = false;
        operations = 0;
        counter = 0;                
        history.text = "";
    }

    public void backspace()
    {
        if (txtdisplay.text != "")
        {
            txtdisplay.text = txtdisplay.text.Substring(0, txtdisplay.text.Length - 1);
        }
        
    }
}
