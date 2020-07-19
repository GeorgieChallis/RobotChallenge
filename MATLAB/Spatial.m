function [] = Spatial()    
%Calculate and plot fft for Seismic Activity Task

    X = load('C:/Users/Georgina/Desktop/Robotics Challenge HHA/GCSpatialVortex.txt');
    L = numel(X);         %Length of signal
    Fs = 46;              %Sampling frequeny
    T = 1/Fs;             % Sampling period             
    t = (0:L-1)*T;        % Time vector
    
    X= X-mean(X); %Remove DC component
    
    Y = fft(X);
    P2 = abs(Y/L);
    P1 = P2(1:L/2+1);
    P1(2:end-1) = 2*P1(2:end-1); 

    figure;
    plot(t,X);


    hold on
    %plot(t,up,t,lo,'linewidth',1.5)
    title('Signal Response:')
    %legend('Signal','up','lo')
    %t= annotation('textbox',[0.05 0.01 0.9 0.05],'String',{['Maximum Amplitude is ' num2str(MaxAmplitude(1)) ' at time ' num2str(MaxTime) '. % of T where Max Amp is: ' num2str(MaxPercentage) '%.  The signal was (Secs): ' num2str(p,3)]});
    
   
    fid = fopen('C:/Users/Georgina/Desktop/Robotics Challenge HHA/GCSpatialVortex.txt');
    tline = fgetl(fid);
    initial = str2num(tline);
    turnct = 0;
    started = false;
    
    while ischar(tline)
        num = str2num(tline);
        if (started == false)
            if ((num > initial+3)||(num < initial-3)) 
                started = true;
            end
        else
            if ((initial < num+0.5)&&(initial > num-0.5))
               turnct=turnct+1; 
            end
        end
        tline = fgetl(fid);
    end
    disp(turnct)
    fclose(fid);
end
