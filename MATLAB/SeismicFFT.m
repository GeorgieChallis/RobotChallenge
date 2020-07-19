function [MaxPercentage, timeRecorded] = SeismicFFT()    
%Calculate and plot fft for Seismic Activity Task

    X = load('C:\Users\Georgina\Desktop\Robotics Challenge HHA\GCSeismicActivity.txt');
    L = numel(X);         %Length of signal
    Fs = 46;              %Sampling frequency
    T = 1/Fs;             % Sampling period             
    t = (0:L-1)*T;        % Time vector
    
    X= X-mean(X); %Remove DC component
    
    Y = fft(X);
    P2 = abs(Y/L);
    P1 = P2(1:L/2+1);
    P1(2:end-1) = 2*P1(2:end-1); 
    f = Fs*(0:(L/2))/L;
    
    MaxElement= find(X==max(X))
    MaxAmplitude= X(MaxElement(1))
    MaxPercentage = (MaxElement(1)/L)*100
    MaxTime = MaxElement(1)*T
    
    figure;
    plot(t,X);
   
    timeRecorded = L/Fs;
    [up,lo] = envelope(X,25,'peak');
    hold on
    plot(t,up,t,lo,'linewidth',1.5)
    title('Signal Response:')
    legend('Signal','up','lo')
    t= annotation('textbox',[0.05 0.01 0.9 0.05],'String',{['Maximum Amplitude is ' num2str(MaxAmplitude(1)) ' at time ' num2str(MaxTime)]});
    
    
    figure;
    ScalePeaks = MaxAmplitude(1)*0.4;
    findpeaks(P1,f,'MinPeakProminence', ScalePeaks)
    title('Frequency Response:')
    xlabel('f (Hz)')
    ylabel('|P1(f)|')
    
    

end

