#!/usr/bin/env python
# coding: utf-8

# In[7]:


from __future__ import print_function
import argparse
import numpy  as np
from PIL import Image
import torch
import torch.nn as nn
import torch.nn.functional as F
import torchvision
import torch.optim as optim
from torch.utils.data import DataLoader, Dataset
from torch.utils.data.sampler import SubsetRandomSampler
from torchvision import transforms
import pdb
from data_loaders import Plain_Dataset, eval_data_dataloader
from deep_emotion import Deep_Emotion
from generate_data import Generate_data
import pyodbc 
from deep_emotion_recognition import DeepEmotionRecognizer
import sounddevice as sd
import soundfile as sf
from pydub import AudioSegment
import cv2
import matplotlib.pyplot as plt
import numpy as np
from datetime import datetime
import imutils


# In[6]:


#Loading visual emotion recognition model
device = torch.device("cuda:0" if torch.cuda.is_available() else "cpu")

net = Deep_Emotion()
net.load_state_dict(torch.load('DeepEmotion_trained_by_VIDGA.pt'))
net.to(device)


#defining sound recording function
#Loading audio emotion recognition model

def recordSound():
    print(".")
    samplerate = 44100  # Hertz
    duration = 1  # seconds
    filename = 'output.wav'

    mydata = sd.rec(int(samplerate * duration), samplerate=samplerate,
                    channels=1, blocking=True)
    sf.write(filename, mydata, samplerate)

# initialize instance
# inherited from emotion_recognition.EmotionRecognizer
# default parameters (LSTM: 128x2, Dense:128x2)
deeprec = DeepEmotionRecognizer(emotions=['angry', 'sad', 'neutral', 'ps', 'happy'], n_rnn_layers=2, n_dense_layers=2, rnn_units=128, dense_units=128)
# train the model
deeprec.train()
# get the accuracy
print(deeprec.test_score())
# predict angry audio sample


##################################################3


# In[ ]:


path = "haarcascade_frontalface_default.xml"
font_scale = 1.5
font = cv2.FONT_HERSHEY_PLAIN

#set the rectangle background to white
rectangle_bgr = (255, 255, 255)
# make a black image
img = np.zeros((500, 500))
#set some text
text = "VİDGA Projesi"
#get the width and height of the text box
(text_width, text_height) = cv2.getTextSize(text, font, fontScale=font_scale, thickness=1)[0]
#set the text start position
text_offset_x = 10
text_offset_y = img.shape[0] - 25
#make the coords of the box with a small padding of two pixels
box_coords = ((text_offset_x, text_offset_y), (text_offset_x + text_width + 2, text_offset_y - text_height -2))
cv2.rectangle(img, box_coords[0], box_coords[1], rectangle_bgr, cv2.FILLED)
cv2.putText(img, text, (text_offset_x, text_offset_y), font, fontScale=font_scale, color= (0,0,0), thickness=1)

cap = cv2.VideoCapture("deneme.mp4")
cap.set(cv2.CAP_PROP_FRAME_WIDTH, 640)
cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 480)

#Check if the webcam is opened correctly
if not cap.isOpened():
    print("check")
    cap = cv2.VideoCapture("deneme.mp4")
    
if not cap.isOpened():
    print("check")
    raise IOError("Cannot open webcam")
    
while True:
    ret, frame = cap.read()
    #print(frame)
    #frame = imutils.resize(frame, width=320, height=480)
    #eye_Cascade = cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_eye.xml')
    faceCascade = cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_frontalface_default.xml')
    #faceCascade = cv2.CascadeClassifier(cv2.data.haarcascades + 'frontal-face-data.xml')
    #print("ret is " + str(ret))
    #cv2.imshow('VIDGA Emotion Recognition', frame) 
    if ret == True:
    
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
        #print(faceCascade.empty())
        faces = faceCascade.detectMultiScale(gray,1.1,4)
        print(faces)
        for x,y,w,h in faces:
            print("Alındı.")
            roi_gray = gray[y:y+h, x:x+w]
            roi_color = frame[y:y+h, x:x+w]
            cv2.rectangle(frame, (x,y), (x+w, y+h), (255, 0, 0), 2)
            facess = faceCascade.detectMultiScale(roi_gray)
            if len(facess) == 0:
                print("Face not detected")
            else: 
                print("else")
                for(ex,ey,ew,eh) in facess:
                    face_roi = roi_color[ey: ey+eh, ex: ex+ew] ##cropping the face
                
    graytemp = cv2.cvtColor(face_roi, cv2.COLOR_BGR2GRAY)
    final_image = cv2.resize(graytemp, (48,48))
    final_image = np.expand_dims(final_image, axis =0) #add third dimension
    final_image = np.expand_dims(final_image, axis =0) #add fourth dimension
    final_image = final_image/255.0 # normalization
    dataa = torch.from_numpy(final_image)
    dataa = dataa.type(torch.FloatTensor)
    dataa = dataa.to(device)
    outputs = net(dataa)
    Pred = F.softmax(outputs, dim=1)
    Predictions = torch.argmax(Pred).item()
    print(Predictions)
    
    #sound Recording and result
    recordSound()
    prediction = deeprec.predict('output.wav')
    print(f"Prediction: {prediction}")
    
    ############ Here comes SQL for Face Emotion ############
    import pyodbc 

    server = 'DESKTOP-T7OFQV6\SQLEXPRESS1'
    database = 'VidgaEmotionRecognition'

    #defining connection string
    cnxn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER=' + server + ';DATABASE=' + database +';Trusted_Connection=yes;')

    #creating the connection cursor
    cursor = cnxn.cursor()

    #defining insert query
    insert_query='''INSERT INTO FaceEmotion (emotion, dateOfNow)
                    VALUES (?, ?);'''

    #defining insertion value
    values = [Predictions, datetime.now().time().second]

    #insert the data
    cursor.execute(insert_query, values)

    #commit the insertion
    cnxn.commit()

    #grab the database table values
    cursor.execute('SELECT * FROM FaceEmotion')

    #printing the results
    """for values in cursor:
        print(values)"""
    
   ############ Here comes SQL for Audio Emotion ############ 

    #defining insert query for audio emotion
    insert_query2='''INSERT INTO SpeechEmotion (emotion, dateOfNow)
                    VALUES (?, ?);'''
    
    #defining insertion value
    values2 = [prediction, datetime.now().time().second]
    
    #insert the data
    cursor.execute(insert_query2, values2)
    
    #commit the insertion
    cnxn.commit()
    
    #grab the database table values
    cursor.execute('SELECT * FROM FaceEmotion')
    
    font = cv2.FONT_HERSHEY_SIMPLEX
    
    font_scale = 1.5
    font = cv2.FONT_HERSHEY_PLAIN
    
    if ((Predictions)==0):
        status = "Angry"
        
        x1,y1,w1,h1, = 0,0,175,5
        # Draw black background rectangle
        cv2.rectangle(frame, (x1, x1), (x1 + w1, y1 + h1), (0,0,0), -1)
        # Add text
        cv2.putText(frame, status, (x1 + int(w1/10), y1 + int(h1/2)), cv2.FONT_HERSHEY_SIMPLEX, 0.7, (0,0,255), 2)
        
        cv2.putText(frame, status, (100,150), font, 3,(0,0,255), 2, cv2.LINE_4)
        
        cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 0, 255))
        
    elif ((Predictions)==1):
        status = "Disgust"
        
        x1,y1,w1,h1, = 0,0,175,5
        # Draw black background rectangle
        cv2.rectangle(frame, (x1, x1), (x1 + w1, y1 + h1), (0,0,0), -1)
        # Add text
        cv2.putText(frame, status, (x1 + int(w1/10), y1 + int(h1/2)), cv2.FONT_HERSHEY_SIMPLEX, 0.7, (0,0,255), 2)
        
        cv2.putText(frame, status, (100,150), font, 3,(0,0,255), 2, cv2.LINE_4)
        
        cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 0, 255))
        
    elif ((Predictions)==2):
        status = "Fear"
        
        x1,y1,w1,h1, = 0,0,175,5
        # Draw black background rectangle
        cv2.rectangle(frame, (x1, x1), (x1 + w1, y1 + h1), (0,0,0), -1)
        # Add text
        cv2.putText(frame, status, (x1 + int(w1/10), y1 + int(h1/2)), cv2.FONT_HERSHEY_SIMPLEX, 0.7, (0,0,255), 2)
        
        cv2.putText(frame, status, (100,150), font, 3,(0,0,255), 2, cv2.LINE_4)
        
        cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 0, 255))
        
    elif ((Predictions)==3):
        status = "Happy"
        
        x1,y1,w1,h1, = 0,0,175,5
        # Draw black background rectangle
        cv2.rectangle(frame, (x1, x1), (x1 + w1, y1 + h1), (0,0,0), -1)
        # Add text
        cv2.putText(frame, status, (x1 + int(w1/10), y1 + int(h1/2)), cv2.FONT_HERSHEY_SIMPLEX, 0.7, (0,0,255), 2)
        
        cv2.putText(frame, status, (100,150), font, 3,(0,0,255), 2, cv2.LINE_4)
        
        cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 0, 255))
        
    elif ((Predictions)==4):
        status = "Sad"
        
        x1,y1,w1,h1, = 0,0,175,5
        # Draw black background rectangle
        cv2.rectangle(frame, (x1, x1), (x1 + w1, y1 + h1), (0,0,0), -1)
        # Add text
        cv2.putText(frame, status, (x1 + int(w1/10), y1 + int(h1/2)), cv2.FONT_HERSHEY_SIMPLEX, 0.7, (0,0,255), 2)
        
        cv2.putText(frame, status, (100,150), font, 3,(0,0,255), 2, cv2.LINE_4)
        
        cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 0, 255))
        
    elif ((Predictions)==5):
        status = "Surprised"
        
        x1,y1,w1,h1, = 0,0,175,5
        # Draw black background rectangle
        cv2.rectangle(frame, (x1, x1), (x1 + w1, y1 + h1), (0,0,0), -1)
        # Add text
        cv2.putText(frame, status, (x1 + int(w1/10), y1 + int(h1/2)), cv2.FONT_HERSHEY_SIMPLEX, 0.7, (0,0,255), 2)
        
        cv2.putText(frame, status, (100,150), font, 3,(0,0,255), 2, cv2.LINE_4)
        
        cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 0, 255))
        
    elif ((Predictions)==6):
        status = "Neutral"
        
        x1,y1,w1,h1, = 0,0,175,5
        # Draw black background rectangle
        cv2.rectangle(frame, (x1, x1), (x1 + w1, y1 + h1), (0,0,0), -1)
        # Add text
        cv2.putText(frame, status, (x1 + int(w1/10), y1 + int(h1/2)), cv2.FONT_HERSHEY_SIMPLEX, 0.7, (0,0,255), 2)
        
        cv2.putText(frame, status, (100,150), font, 3,(0,0,255), 2, cv2.LINE_4)
        
        cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 0, 255))
    
    
    if ret == True:
        cv2.imshow('VIDGA Emotion Recognition', frame) 
            
            
    if cv2.waitKey(2) & 0xFF == ord('q'):
        raise SystemExit(...)

            
cap.release()
cv2.destroyAllWindows


# In[ ]:




