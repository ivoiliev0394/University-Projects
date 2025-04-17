// Функция за генериране на 10 цели случайни числа в масив
function generateRandomArray() {
    const array = [];
    for (let i = 0; i < 10; i++) {
        array.push(Math.floor(Math.random() * 10)); // Генериране на случайно число от 0 до 99
    }
    return array;
}

// Функция за намиране на броя на елементите, равни на въведеното число
function countOccurrences(array, number) {
    let count = 0;
    for (let i = 0; i < array.length; i++) {
        if (array[i] === number) {
            count++;
        }
    }
    return count;
}

// Генериране на масив
const randomArray = generateRandomArray();

// Въвеждане на число от потребителя
const userNumber = parseInt(prompt("Въведете число:"));

// Намиране на броя на елементите, равни на въведеното число
const occurrencesCount = countOccurrences(randomArray, userNumber);

// Извеждане на елементите на масива и резултата
console.log("Елементи на масива:", randomArray);
console.log(`Брой на елементите, равни на ${userNumber}: ${occurrencesCount}`);
