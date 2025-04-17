let suma=0;
for(let i=2;i<=10;i+=2)
{
    suma+=i;
}
console.log(suma);
//document.write(suma+"\n");
suma=0;
for(let i=1;i<=30;i+=2)
{
    suma+=i;
}
console.log(suma);
//document.write(suma+"\n");

var den;
switch(new Date().getDay())
{
    case 0: day="Неделя"; break;
    case 1: day="Понеделник"; break;
    case 2: day="Вторник"; break;
    case 3: day="Сряда"; break;
    case 4: day="Четвъртък"; break;
    case 5: day="Петък"; break;
    case 6: day="Събота"; break;
}
//document.write(day+"\n");

console.log(day);
