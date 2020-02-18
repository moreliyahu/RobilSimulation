﻿/*
© Siemens AG, 2018
Author: Berkay Alp Cakal (berkay_alp.cakal.ct@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class LaserScanPublisher : Publisher<Messages.Sensor.LaserScan>
    {
        public string FrameId = "Unity";

        private Messages.Sensor.LaserScan message;

        
        //**check this***/
        //time between measurements [seconds] - if your scanner is moving, this will be used in interpolating position of 3d points
        public float time_increment;
        //*******check this and also missing in our code msg********/
        //time between scans [seconds]
        public float scan_time;
        
                
        protected override void Start()
        {
            base.Start();
            //InitializeMessage();
        }


        private void UpdateMessage()
        {
            //message.header.Update();
            //laserScanReader.Scan();
            //Publish(message);
        }

        public void PublishMessage(Messages.Sensor.LaserScan message){
            message.header = new Messages.Standard.Header { frame_id = FrameId };
            message.header.Update();
            Publish(message);

        }
    }
}
