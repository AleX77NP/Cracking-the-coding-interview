# Reverse C-type string 

def reverse_c_string(sentence):
    reversed = ""
    for i in range(0, len(sentence)):
        reversed += sentence[len(sentence) - i - 1]
    return reversed + '\0'


print(reverse_c_string('abcd\0'))
