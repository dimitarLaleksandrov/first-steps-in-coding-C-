function wordsUppercase(word) {
    return word.match(/\w+/g).join(", ").toUpperCase();
}
console.log(wordsUppercase('Hi, how are you?'));