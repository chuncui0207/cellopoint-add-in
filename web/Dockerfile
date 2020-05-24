FROM node:10.20.1
RUN ln -sf /usr/share/zoneinfo/Asia/ShangHai /etc/localtime
RUN echo "Asia/Shanghai" > /etc/timezone
RUN dpkg-reconfigure -f noninteractive tzdata

WORKDIR /usr/src/app  

EXPOSE 9527