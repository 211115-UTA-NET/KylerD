'use strict'


function myFunction()
{
    document.getElementById("TEST").innerHTML = "NEW";
}

function formFunction()
{
    var x = document.getElementById("form");
    var text = "";
    var i;

    /* for(i = 0; i < x.length; i++)
    {
        text += x.elements[i].value + "<br>";
    } */

    const person = {fname: "John", lname: "Doe"}

    for(let j in person)
    {
        text += person[j] + "<br>";
    }

    /* let batch = '
        {"Associates" : [' +
            '{
                "fname":["Travis"],
                "lname":["Boskowitz"]
            },' +
            '{
                "fname":["Jing"],
                "lname":["Zhuang"]
            },' +
            '{
                "fname":["Melinda"],
                "lname":["Waggoner"]
            }
        ]}' */

    let batch = 
        '{"Associates" : [' +
            '{"fname":["Travis"], "lname":["Boskowitz"]},' +
            '{"fname":["Jing"], "lname":["Zhuang"]},' +
            '{"fname":["Melinda"], "lname":["Waggoner"]}]}'

    const obj = JSON.parse(batch);

    const myJSON = JSON.stringify(obj);

    document.getElementById("formOut").innerHTML = myJSON;
}