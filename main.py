import cvzone
from cvzone.ColorModule import ColorFinder
import cv2
import socket

cap = cv2.VideoCapture(0)
cap.set(3,1280)
cap.set(4, 720)

success, img = cap.read()
h,w,_= img.shape


myColorFinder = ColorFinder(True)
hsvVals = {'hmin': 103, 'smin': 107, 'vmin': 0, 'hmax': 179, 'smax': 255, 'vmax': 255}
(988, 172, 13666)

sock = socket.socket(socket.AF_INET,socket.SOCK_DGRAM)
serverAddressPort = ("127.0.0.1",1042)

while True:
    success, img = cap.read()
    imgColor,mask = myColorFinder.update(img, hsvVals)
    imgContour,contours = cvzone.findContours(img,mask)

    if contours :
        data = contours [0]['center'][0],\
               h-contours [0]['center'][1], \
               int (contours[0]['area'])
        print(data)
        sock.sendto(str.encode( str(data)),serverAddressPort)


    # imgStImage",imgStack)ack = cvzone.stackImages([img,imgColor,mask,imgContour],2,0.5)
    # cv2.imshow("imgStImage");
    imgContour = cv2.resize(imgContour,(0,0),None,0.3,0.3)
    cv2.imshow("ImageContour",imgContour)
    cv2.waitKey(1)
