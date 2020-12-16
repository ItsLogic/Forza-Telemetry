using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Forza_Telemetry
{
    public partial class ForzaTelemetry : Form
    {
            UdpClient Client = new UdpClient(11111); //port

            public ForzaTelemetry()
            {
                InitializeComponent();
            }
            private void BTN_Test1_Click(object sender, EventArgs e)
            {
            TextBox_UDPOutput.Text = "test";
                try
                {
                    Client.BeginReceive(new AsyncCallback(recv), null);
                }
                catch (Exception ex)
                {
                    TextBox_UDPOutput.Text = ex.Message.ToString();
                }
            }

            void recv(IAsyncResult res)
            {
                IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 60240);
                byte[] received = Client.EndReceive(res, ref RemoteIP);
                using (MemoryStream stream = new MemoryStream(received))
                using (BinaryReader reader = new BinaryReader(stream))

                    this.Invoke(new MethodInvoker(delegate
                    {
                        int IsRaceOn = reader.ReadInt32();
                        uint TimestampMS = reader.ReadUInt32();

                        float EngineMaxRpm = reader.ReadSingle();
                        float EngineIdleRpm = reader.ReadSingle();
                        float CurrentEngineRpm = reader.ReadSingle();

                        float AccelerationX = reader.ReadSingle();
                        float AccelerationY = reader.ReadSingle();
                        float AccelerationZ = reader.ReadSingle();

                        float VelocityX = reader.ReadSingle();
                        float VelocityY = reader.ReadSingle();
                        float VelocityZ = reader.ReadSingle();

                        float AngularVelocityX = reader.ReadSingle();
                        float AngularVelocityY = reader.ReadSingle();
                        float AngularVelocityZ = reader.ReadSingle();

                        float Yaw = reader.ReadSingle();
                        float Pitch = reader.ReadSingle();
                        float Roll = reader.ReadSingle();

                        float NormalizedSuspensionTravelFrontLeft = reader.ReadSingle();
                        float NormalizedSuspensionTravelFrontRight = reader.ReadSingle();
                        float NormalizedSuspensionTravelRearLeft = reader.ReadSingle();
                        float NormalizedSuspensionTravelRearRight = reader.ReadSingle();

                        float TireSlipRatioFrontLeft = reader.ReadSingle();
                        float TireSlipRatioFrontRight = reader.ReadSingle();
                        float TireSlipRatioRearLeft = reader.ReadSingle();
                        float TireSlipRatioRearRight = reader.ReadSingle();

                        float WheelRotationSpeedFrontLeft = reader.ReadSingle();
                        float WheelRotationSpeedFrontRight = reader.ReadSingle();
                        float WheelRotationSpeedRearLeft = reader.ReadSingle();
                        float WheelRotationSpeedRearRight = reader.ReadSingle();

                        int WheelOnRumbleStripFrontLeft = reader.ReadInt32();
                        int WheelOnRumbleStripFrontRight = reader.ReadInt32();
                        int WheelOnRumbleStripRearLeft = reader.ReadInt32();
                        int WheelOnRumbleStripRearRight = reader.ReadInt32();

                        float WheelInPuddleDepthFrontLeft = reader.ReadSingle();
                        float WheelInPuddleDepthFrontRight = reader.ReadSingle();
                        float WheelInPuddleDepthRearLeft = reader.ReadSingle();
                        float WheelInPuddleDepthRearRight = reader.ReadSingle();

                        float SurfaceRumbleFrontLeft = reader.ReadSingle();
                        float SurfaceRumbleFrontRight = reader.ReadSingle();
                        float SurfaceRumbleRearLeft = reader.ReadSingle();
                        float SurfaceRumbleRearRight = reader.ReadSingle();

                        float TireSlipAngleFrontLeft = reader.ReadSingle();
                        float TireSlipAngleFrontRight = reader.ReadSingle();
                        float TireSlipAngleRearLeft = reader.ReadSingle();
                        float TireSlipAngleRearRight = reader.ReadSingle();

                        float TireCombinedSlipFrontLeft = reader.ReadSingle();
                        float TireCombinedSlipFrontRight = reader.ReadSingle();
                        float TireCombinedSlipRearLeft = reader.ReadSingle();
                        float TireCombinedSlipRearRight = reader.ReadSingle();

                        float SuspensionTravelMetersFrontLeft = reader.ReadSingle();
                        float SuspensionTravelMetersFrontRight = reader.ReadSingle();
                        float SuspensionTravelMetersRearLeft = reader.ReadSingle();
                        float SuspensionTravelMetersRearRight = reader.ReadSingle();

                        int CarOrdinal = reader.ReadInt32();
                        int CarClass = reader.ReadInt32();
                        int CarPerformanceIndex = reader.ReadInt32();
                        int DrivetrainType = reader.ReadInt32();
                        int NumCylinders = reader.ReadInt32();

                        float unknownvalue1 = reader.ReadSingle();
                        float unknownvalue2 = reader.ReadSingle();
                        float unknownvalue3 = reader.ReadSingle();

                        float PositionX = reader.ReadSingle();
                        float PositionY = reader.ReadSingle();
                        float PositionZ = reader.ReadSingle();

                        float Speed = reader.ReadSingle();
                        float Power = reader.ReadSingle();
                        float Torque = reader.ReadSingle();

                        float TireTempFrontLeft = reader.ReadSingle();
                        float TireTempFrontRight = reader.ReadSingle();
                        float TireTempRearLeft = reader.ReadSingle();
                        float TireTempRearRight = reader.ReadSingle();

                        float Boost = reader.ReadSingle();
                        float Fuel = reader.ReadSingle();
                        float DistanceTraveled = reader.ReadSingle();
                        float BestLap = reader.ReadSingle();
                        float LastLap = reader.ReadSingle();
                        float CurrentLap = reader.ReadSingle();
                        float CurrentRaceTime = reader.ReadSingle();

                        uint LapNumber = reader.ReadUInt16();
                        uint RacePosition = reader.ReadByte(); 
                        uint Accel = reader.ReadByte();
                        uint Brake = reader.ReadByte();
                        uint Clutch = reader.ReadByte();
                        uint Handbrake = reader.ReadByte();
                        uint Gear = reader.ReadByte();
                        int Steer = reader.ReadSByte();

                        int NormalizedDrivingLine = reader.ReadSByte();
                        int NormalizedAIBrakeDifference = reader.ReadSByte();

                        TextBox_UDPOutput.Text = 

                        "IsRaceOn: " + IsRaceOn +
                        "\nTimestampMS: " + TimestampMS + 
                        "\nMaxEngineRpm: " + EngineMaxRpm +
                        "\nEngineIdleRpm: " + EngineIdleRpm + 
                        "\nCurrentEngineRpm: " + CurrentEngineRpm + 
                        "\nAccelerationX: " + AccelerationX + 
                        "\nAccelerationY: " + AccelerationY + 
                        "\nAccelerationZ: " + AccelerationZ + 
                        "\nVelocityX: " + VelocityX + 
                        "\nVelocityY: " + VelocityY + 
                        "\nVelocityZ: " + VelocityZ + 
                        "\nAngularVelocityX: " + AngularVelocityX + 
                        "\nAngularVelocityY: " + AngularVelocityY + 
                        "\nAngularVelocityZ: " +  AngularVelocityZ + 
                        "\nYaw: " + Yaw + 
                        "\nPitch: " + Pitch + 
                        "\nRoll: " + Roll + 
                        "\nNormalizedSuspensionTravelFrontLeft: " + NormalizedSuspensionTravelFrontLeft + 
                        "\nNormalizedSuspensionTravelFrontRight: " + NormalizedSuspensionTravelFrontRight + 
                        "\nNormalizedSuspensionTravelRearLeft: " + NormalizedSuspensionTravelRearLeft + 
                        "\nNormalizedSuspensionTravelRearRight: " + NormalizedSuspensionTravelRearRight + 
                        "\nTireSlipRatioFrontLeft: " + TireSlipRatioFrontLeft + 
                        "\nTireSlipRatioFrontRight: " +  TireSlipRatioFrontRight + 
                        "\nTireSlipRatioRearLeft: " + TireSlipRatioRearLeft + 
                        "\nTireSlipRatioRearRight: " +  TireSlipRatioRearRight + 
                        "\nWheelRotationSpeedFrontLeft: " +  WheelRotationSpeedFrontLeft + 
                        "\nWheelRotationSpeedFrontRight: " + WheelRotationSpeedFrontRight + 
                        "\nWheelRotationSpeedRearLeft: " + WheelRotationSpeedRearLeft + 
                        "\nWheelRotationSpeedRearRight: " + WheelRotationSpeedRearRight + 
                        "\nWheelOnRumbleStripFrontLeft: " + WheelOnRumbleStripFrontLeft + 
                        "\nWheelOnRumbleStripFrontRight: " + WheelOnRumbleStripFrontRight + 
                        "\nWheelOnRumbleStripRearLeft: " + WheelOnRumbleStripRearLeft + 
                        "\nWheelOnRumbleStripRearRight: " + WheelOnRumbleStripRearRight + 
                        "\nWheelInPuddleDepthFrontLeft: " + WheelInPuddleDepthFrontLeft +
                        "\nWheelInPuddleDepthFrontRight: " + WheelInPuddleDepthFrontRight + 
                        "\nWheelInPuddleDepthRearLeft: " + WheelInPuddleDepthRearLeft + 
                        "\nWheelInPuddleDepthRearRight: " + WheelInPuddleDepthRearRight + 
                        "\nSurfaceRumbleFrontLeft: " + SurfaceRumbleFrontLeft + 
                        "\nSurfaceRumbleFrontRight: " + SurfaceRumbleFrontRight + 
                        "\nSurfaceRumbleRearLeft: " + SurfaceRumbleRearLeft + 
                        "\nSurfaceRumbleRearRight: " + SurfaceRumbleRearRight + 
                        "\nTireSlipAngleFrontLeft: " + TireSlipAngleFrontLeft + 
                        "\nTireSlipAngleFrontRight: " + TireSlipAngleFrontRight + 
                        "\nTireSlipAngleRearLeft: " + TireSlipAngleRearLeft + 
                        "\nTireSlipAngleRearRight: " + TireSlipAngleRearRight + 
                        "\nTireCombinedSlipFrontLeft: " + TireCombinedSlipFrontLeft + 
                        "\nTireCombinedSlipFrontRight: " + TireCombinedSlipFrontRight + 
                        "\nTireCombinedSlipRearLeft: " + TireCombinedSlipRearLeft + 
                        "\nTireCombinedSlipRearRight: " + TireCombinedSlipRearRight + 
                        "\nSuspensionTravelMetersFrontLeft: " +  SuspensionTravelMetersFrontLeft + 
                        "\nSuspensionTravelMetersFrontRight: " + SuspensionTravelMetersFrontRight + 
                        "\nSuspensionTravelMetersRearLeft: " + SuspensionTravelMetersRearLeft + 
                        "\nSuspensionTravelMetersRearRight: " + SuspensionTravelMetersRearRight ;

                        TextBox_UDPOutput2.Text =
                        "CarID:" + CarOrdinal +
                        "\nCarClass: " + CarClass +
                        "\nCarPerformanceIndex: " + CarPerformanceIndex +
                        "\nDrivetrainType: " + DrivetrainType +
                        "\nNumCylinders: " + NumCylinders +
                        "\nPositionX: " + PositionX +
                        "\nPositionY: " + PositionY +
                        "\nPositionZ: " + PositionZ +
                        "\nSpeed: " + Speed +
                        "\nPower: " + Power +
                        "\nTorque: " + Torque +
                        "\nTireTempFrontLeft: " + TireTempFrontLeft +
                        "\nTireTempFrontRight: " + TireTempFrontRight +
                        "\nTireTempRearLeft: " + TireTempRearLeft +
                        "\nTireTempRearRight: " + TireTempRearRight +
                        "\nBoost: " + Boost +
                        "\nFuel: " + Fuel +
                        "\nDistanceTraveled: " + DistanceTraveled +
                        "\nBestLap: " + BestLap +
                        "\nLastLap: " + LastLap +
                        "\nCurrentLap: " + CurrentLap +
                        "\nCurrentRaceTime: " + CurrentRaceTime +
                        "\nLapNumber: " + LapNumber + //First lap is counted as lap 0
                        "\nRacePosition: " + RacePosition +
                        "\nAccel: " + Accel +
                        "\nBrake: " + Brake +
                        "\nClutch: " + Clutch +
                        "\nHandbrake: " + Handbrake +
                        "\nGear: " + Gear +
                        "\nSteer: " + Steer +
                        "\nNormalizedDrivingLine: " + NormalizedDrivingLine +
                        "\nNormalizedAIBrakeDifference: " + NormalizedAIBrakeDifference
                        ;
                        
                    }

                ));

                Client.BeginReceive(new AsyncCallback(recv), null);


            }

     
    }
}
