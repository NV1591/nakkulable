##Sample URL Shortner in python. I know this would be a 
##stupid approach to do things but this was just a part of 
##a contest that me and my room mate got into and apparently 
##I was doing this while applying for the school.
##So I thought maybe I should post this.


import pickle
import random

def main(url):
    short = pickShortUrl(url)
    print "Short url to your long url %s is %s" %(url, short)

def pickShortUrl(url):
    dict = deserializeDict() 
    key = 0
	
    if dict is None:     #Create new dictionary if the file has not been instantiated.
        dict = createDict()
						
    result, key = queryDict(url, key, dict) #Query the dictionary for the short url if already present.
    if result:
        short = result
    else:
        key = 1		
        emptyurl, num = queryDict(url, key, dict) #Query the dictionary for the key to the last url pair in the dictionary.
        short = "http://yousu.ck/" + _base62encode(num + 1)
        dict[num] = [short, url]
        serializeDict(dict) #Serialize the object back to the file 
		
    return str(short)

def _base62encode(number): 
    s = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ' #list of all the strings used for encoding
    alphabet = ''.join(random.sample(s, len(s))) #shuffle the strings
    base62 = ''

    while number:
        number, i = divmod(number, 62)  #convert the number to base62 and generate the new url
        base62 = alphabet[i] + base62

    return base62 
	
	
def queryDict(longurl, key, dict):	
	shorturl = ''
				
	if key == 0:	
		for lists in dict.values():
			if longurl in lists[1]:
				shorturl = lists[0]
	else:
		key = dict.keys()[-1] 		
	
	return shorturl, key	
	
def serializeDict(obj):
	file = open('dictfile.txt', 'wb')
	file.truncate()
	pickle.dump(obj, file)

#De-serialize the data present in the file
def deserializeDict():
	file = open('dictfile.txt', 'rb')
	str = file.read()
	if str:
		return pickle.load(file)
		
def createDict():
	return {12321212 : ('', '')}
	
#Entry point of our program
main(raw_input("Enter the desired url."))
		


	
