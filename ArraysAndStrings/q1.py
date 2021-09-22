# Implement an algorithm to determine if a string has all unique characters 
# What if you can not use additional data structures?

def is_string_unique(sentence):
    if len(sentence) > 256:
        return False
    track = [False] * 128
    for character in sentence:
        if track[ord(character)] == True:
            return False
        track[ord(character)] = True
    return True


print(is_string_unique('abcdefg'))