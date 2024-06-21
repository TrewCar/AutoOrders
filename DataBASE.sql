PGDMP     
    ;                |            auto    15.4    15.3 H    [           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            \           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ]           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            ^           1262    108755    auto    DATABASE     x   CREATE DATABASE auto WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE auto;
                postgres    false            �            1259    112648    brand    TABLE     `   CREATE TABLE public.brand (
    id integer NOT NULL,
    name character varying(50) NOT NULL
);
    DROP TABLE public.brand;
       public         heap    postgres    false            �            1259    112647    brand_id_seq    SEQUENCE     �   CREATE SEQUENCE public.brand_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.brand_id_seq;
       public          postgres    false    228            _           0    0    brand_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.brand_id_seq OWNED BY public.brand.id;
          public          postgres    false    227            �            1259    112546    client    TABLE     W  CREATE TABLE public.client (
    id integer NOT NULL,
    phone character varying(20) NOT NULL,
    bisnesclient boolean DEFAULT false,
    lastname text NOT NULL,
    name text NOT NULL,
    midname text,
    email text,
    personal_data boolean DEFAULT false,
    sms_send boolean DEFAULT false,
    complite_opros boolean DEFAULT false
);
    DROP TABLE public.client;
       public         heap    postgres    false            �            1259    112545    client_id_seq    SEQUENCE     �   CREATE SEQUENCE public.client_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.client_id_seq;
       public          postgres    false    215            `           0    0    client_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.client_id_seq OWNED BY public.client.id;
          public          postgres    false    214            �            1259    112641    color    TABLE     `   CREATE TABLE public.color (
    id integer NOT NULL,
    name character varying(50) NOT NULL
);
    DROP TABLE public.color;
       public         heap    postgres    false            �            1259    112640    color_id_seq    SEQUENCE     �   CREATE SEQUENCE public.color_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.color_id_seq;
       public          postgres    false    226            a           0    0    color_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.color_id_seq OWNED BY public.color.id;
          public          postgres    false    225            �            1259    112655    model    TABLE        CREATE TABLE public.model (
    id integer NOT NULL,
    name character varying(50) NOT NULL,
    brand_id integer NOT NULL
);
    DROP TABLE public.model;
       public         heap    postgres    false            �            1259    112654    model_id_seq    SEQUENCE     �   CREATE SEQUENCE public.model_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.model_id_seq;
       public          postgres    false    230            b           0    0    model_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.model_id_seq OWNED BY public.model.id;
          public          postgres    false    229            �            1259    112603    orders    TABLE     U  CREATE TABLE public.orders (
    id integer NOT NULL,
    date date DEFAULT CURRENT_TIMESTAMP,
    id_salon integer,
    id_admin integer,
    id_client integer,
    id_menedger integer,
    status integer DEFAULT 1,
    how_found text DEFAULT ''::text,
    typevizit text DEFAULT ''::text,
    brend text,
    model text,
    color text
);
    DROP TABLE public.orders;
       public         heap    postgres    false            �            1259    112602    orders_id_seq    SEQUENCE     �   CREATE SEQUENCE public.orders_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.orders_id_seq;
       public          postgres    false    224            c           0    0    orders_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.orders_id_seq OWNED BY public.orders.id;
          public          postgres    false    223            �            1259    112560    roles    TABLE     F   CREATE TABLE public.roles (
    id integer NOT NULL,
    name text
);
    DROP TABLE public.roles;
       public         heap    postgres    false            �            1259    112585    salons    TABLE     G   CREATE TABLE public.salons (
    id integer NOT NULL,
    name text
);
    DROP TABLE public.salons;
       public         heap    postgres    false            �            1259    112584    salons_id_seq    SEQUENCE     �   CREATE SEQUENCE public.salons_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.salons_id_seq;
       public          postgres    false    220            d           0    0    salons_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.salons_id_seq OWNED BY public.salons.id;
          public          postgres    false    219            �            1259    112594    status    TABLE     G   CREATE TABLE public.status (
    id integer NOT NULL,
    name text
);
    DROP TABLE public.status;
       public         heap    postgres    false            �            1259    112593    status_id_seq    SEQUENCE     �   CREATE SEQUENCE public.status_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.status_id_seq;
       public          postgres    false    222            e           0    0    status_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.status_id_seq OWNED BY public.status.id;
          public          postgres    false    221            �            1259    112568    users    TABLE     �   CREATE TABLE public.users (
    id integer NOT NULL,
    lastname text NOT NULL,
    name text NOT NULL,
    midname text,
    login text,
    password text,
    id_role integer DEFAULT 1
);
    DROP TABLE public.users;
       public         heap    postgres    false            �            1259    112567    users_id_seq    SEQUENCE     �   CREATE SEQUENCE public.users_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.users_id_seq;
       public          postgres    false    218            f           0    0    users_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.users_id_seq OWNED BY public.users.id;
          public          postgres    false    217            �           2604    112651    brand id    DEFAULT     d   ALTER TABLE ONLY public.brand ALTER COLUMN id SET DEFAULT nextval('public.brand_id_seq'::regclass);
 7   ALTER TABLE public.brand ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    227    228    228            �           2604    112549 	   client id    DEFAULT     f   ALTER TABLE ONLY public.client ALTER COLUMN id SET DEFAULT nextval('public.client_id_seq'::regclass);
 8   ALTER TABLE public.client ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    214    215    215            �           2604    112644    color id    DEFAULT     d   ALTER TABLE ONLY public.color ALTER COLUMN id SET DEFAULT nextval('public.color_id_seq'::regclass);
 7   ALTER TABLE public.color ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    225    226    226            �           2604    112658    model id    DEFAULT     d   ALTER TABLE ONLY public.model ALTER COLUMN id SET DEFAULT nextval('public.model_id_seq'::regclass);
 7   ALTER TABLE public.model ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    230    229    230            �           2604    112606 	   orders id    DEFAULT     f   ALTER TABLE ONLY public.orders ALTER COLUMN id SET DEFAULT nextval('public.orders_id_seq'::regclass);
 8   ALTER TABLE public.orders ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    224    223    224            �           2604    112588 	   salons id    DEFAULT     f   ALTER TABLE ONLY public.salons ALTER COLUMN id SET DEFAULT nextval('public.salons_id_seq'::regclass);
 8   ALTER TABLE public.salons ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    219    220    220            �           2604    112597 	   status id    DEFAULT     f   ALTER TABLE ONLY public.status ALTER COLUMN id SET DEFAULT nextval('public.status_id_seq'::regclass);
 8   ALTER TABLE public.status ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    221    222    222            �           2604    112571    users id    DEFAULT     d   ALTER TABLE ONLY public.users ALTER COLUMN id SET DEFAULT nextval('public.users_id_seq'::regclass);
 7   ALTER TABLE public.users ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    218    217    218            V          0    112648    brand 
   TABLE DATA           )   COPY public.brand (id, name) FROM stdin;
    public          postgres    false    228   �L       I          0    112546    client 
   TABLE DATA           �   COPY public.client (id, phone, bisnesclient, lastname, name, midname, email, personal_data, sms_send, complite_opros) FROM stdin;
    public          postgres    false    215    M       T          0    112641    color 
   TABLE DATA           )   COPY public.color (id, name) FROM stdin;
    public          postgres    false    226   O�       X          0    112655    model 
   TABLE DATA           3   COPY public.model (id, name, brand_id) FROM stdin;
    public          postgres    false    230   ��       R          0    112603    orders 
   TABLE DATA           �   COPY public.orders (id, date, id_salon, id_admin, id_client, id_menedger, status, how_found, typevizit, brend, model, color) FROM stdin;
    public          postgres    false    224   _�       J          0    112560    roles 
   TABLE DATA           )   COPY public.roles (id, name) FROM stdin;
    public          postgres    false    216   |�       N          0    112585    salons 
   TABLE DATA           *   COPY public.salons (id, name) FROM stdin;
    public          postgres    false    220   Ɉ       P          0    112594    status 
   TABLE DATA           *   COPY public.status (id, name) FROM stdin;
    public          postgres    false    222   �       L          0    112568    users 
   TABLE DATA           V   COPY public.users (id, lastname, name, midname, login, password, id_role) FROM stdin;
    public          postgres    false    218   ��       g           0    0    brand_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.brand_id_seq', 6, true);
          public          postgres    false    227            h           0    0    client_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.client_id_seq', 500, true);
          public          postgres    false    214            i           0    0    color_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.color_id_seq', 6, true);
          public          postgres    false    225            j           0    0    model_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.model_id_seq', 18, true);
          public          postgres    false    229            k           0    0    orders_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.orders_id_seq', 1, false);
          public          postgres    false    223            l           0    0    salons_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.salons_id_seq', 1, true);
          public          postgres    false    219            m           0    0    status_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.status_id_seq', 5, true);
          public          postgres    false    221            n           0    0    users_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.users_id_seq', 15, true);
          public          postgres    false    217            �           2606    112653    brand brand_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.brand
    ADD CONSTRAINT brand_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.brand DROP CONSTRAINT brand_pkey;
       public            postgres    false    228            �           2606    112559    client client_phone_key 
   CONSTRAINT     S   ALTER TABLE ONLY public.client
    ADD CONSTRAINT client_phone_key UNIQUE (phone);
 A   ALTER TABLE ONLY public.client DROP CONSTRAINT client_phone_key;
       public            postgres    false    215            �           2606    112557    client client_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.client
    ADD CONSTRAINT client_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.client DROP CONSTRAINT client_pkey;
       public            postgres    false    215            �           2606    112646    color color_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.color
    ADD CONSTRAINT color_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.color DROP CONSTRAINT color_pkey;
       public            postgres    false    226            �           2606    112660    model model_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.model
    ADD CONSTRAINT model_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.model DROP CONSTRAINT model_pkey;
       public            postgres    false    230            �           2606    112614    orders orders_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.orders DROP CONSTRAINT orders_pkey;
       public            postgres    false    224            �           2606    112566    roles roles_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.roles DROP CONSTRAINT roles_pkey;
       public            postgres    false    216            �           2606    112592    salons salons_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.salons
    ADD CONSTRAINT salons_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.salons DROP CONSTRAINT salons_pkey;
       public            postgres    false    220            �           2606    112601    status status_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.status
    ADD CONSTRAINT status_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.status DROP CONSTRAINT status_pkey;
       public            postgres    false    222            �           2606    112578    users users_login_key 
   CONSTRAINT     Q   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_login_key UNIQUE (login);
 ?   ALTER TABLE ONLY public.users DROP CONSTRAINT users_login_key;
       public            postgres    false    218            �           2606    112576    users users_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    218            �           2606    112661    model model_brand_id_fkey    FK CONSTRAINT     y   ALTER TABLE ONLY public.model
    ADD CONSTRAINT model_brand_id_fkey FOREIGN KEY (brand_id) REFERENCES public.brand(id);
 C   ALTER TABLE ONLY public.model DROP CONSTRAINT model_brand_id_fkey;
       public          postgres    false    228    230    3248            �           2606    112620    orders orders_id_admin_fkey    FK CONSTRAINT     {   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_id_admin_fkey FOREIGN KEY (id_admin) REFERENCES public.users(id);
 E   ALTER TABLE ONLY public.orders DROP CONSTRAINT orders_id_admin_fkey;
       public          postgres    false    224    3238    218            �           2606    112625    orders orders_id_client_fkey    FK CONSTRAINT     ~   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_id_client_fkey FOREIGN KEY (id_client) REFERENCES public.client(id);
 F   ALTER TABLE ONLY public.orders DROP CONSTRAINT orders_id_client_fkey;
       public          postgres    false    215    3232    224            �           2606    112630    orders orders_id_menedger_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_id_menedger_fkey FOREIGN KEY (id_menedger) REFERENCES public.users(id);
 H   ALTER TABLE ONLY public.orders DROP CONSTRAINT orders_id_menedger_fkey;
       public          postgres    false    218    224    3238            �           2606    112615    orders orders_id_salon_fkey    FK CONSTRAINT     |   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_id_salon_fkey FOREIGN KEY (id_salon) REFERENCES public.salons(id);
 E   ALTER TABLE ONLY public.orders DROP CONSTRAINT orders_id_salon_fkey;
       public          postgres    false    3240    224    220            �           2606    112635    orders orders_status_fkey    FK CONSTRAINT     x   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_status_fkey FOREIGN KEY (status) REFERENCES public.status(id);
 C   ALTER TABLE ONLY public.orders DROP CONSTRAINT orders_status_fkey;
       public          postgres    false    222    224    3242            �           2606    112579    users users_id_role_fkey    FK CONSTRAINT     w   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_id_role_fkey FOREIGN KEY (id_role) REFERENCES public.roles(id);
 B   ALTER TABLE ONLY public.users DROP CONSTRAINT users_id_role_fkey;
       public          postgres    false    216    218    3234            V   B   x�3�ɯ�/I�2����KI�2�t��2��M-JNMI-�uJͫ�2�t�/J�2�t,M������ ��      I      x�u}ks�Ȓ�g�_��׷��r�a{%���c#Yq^��.�����H�0scz�5�r�*'�dfE����"��0ϊ$�?�����f[7Mp��>��n��/;�<��W�M���k�m�U���:xƯ>�s�<N�"��?�ZU/��z��_�~��X�?���ӯo��_��z��yi�?���?�m�w~)�Q-�l���6[��o��ߋ�5*�k_����Y���4��=T�W���U�T5���ڦn_��
+��]����nR.Ʀ(B���o7�������U�՛U�G��G��oyZ�a��G_m��G<ؗ��~�6������>?7������wd�1�)c,r]o�jӵ���~q��z<�/}��=���ש�\'6qd��D��y_��6�����r���v[��,>_-��W)K$Q�SM�=�����#�]UM��v��y�vag��U���w5Q(fehp9�ُ���7�up�c���7�}���m�޵�n~����mo����H���&.˜r���8��7�s�U��U_o���Y��tw�7&������4�������t���n��#��5�~����Lz"1�E"�IV��IB~�m�vlÏ����uc�Ū�um���Wh���'��J"��L�(s���t+H��kq�;��{��뮁V��6�D��<ʲ"�)>v��_�g�z_Q�_7�u�?׶YξV��"j©�D��,N�<O( �f�#�{S��*�]T���v?�^LHP$ҜX�8/B�{�o��8�6�h�ڶۺ���z]��]*>aga�m\VP��j�[�mW]Um:�R���E�T��(J���č�6��o5$q�wЊj�c�s��m�Г�8�E�"�LYP������N��n���λY"R�΢2O����-^�<�,g�ۻ��ė�v9�����ɉ���"�iZ�e	�B���aV���B�vj��f~�;��$�g|a���a�Mi�~`G��S-����P�U���jv[7O�����i?XF$7�BM���~������M�`s���z��ZX>�����.�:�4i���Y+Ҋ�z��m�W�nU�S�$2��q	��P��j�����M����>�Vm��u�̝9�r�H/��ɓ0�;�����Ý}ǡlkB[��gb۴0��e���]��~�ܵ�+�̿ZH��_�ԛN�(Q�v�����=-�$ﬅ{��Ͽ��v�X��2&"�Q����ɉ��o.�z���E9����`��h��<w����y��ek ���=��l]m_l��T0�u�f��Z"���Y̭]ﶯ�! �/����^�_ղ�=�
�ۍ����&��)�?}������~��������B��e�D��>�f�ȁ���ow�V@Iݦф�$"�I�Da���<��kp��բ�Ҍ������l�>OAI���b�S�R�����}�����32i�9�z���KD���H�.�����O�:W��~@�* ����%R�c�ee��o᧞,���0��=l*d[T����&"�aT$e����A�7��Eȣ^3����SGN�1"�=x���Ӣ{�aQߪ�b�^��+]��\!iz���2
(�$)�(�q��;h ��}Oeӓ�F@�f�v<�fD��ؤy�&l+���/�I<X�K^�8��c#b�o��%�iӵ�x�k���ۅm?��=��I៍����"�x[{��պ��-v��:o��(9q�؊�q�aAj�'�#:X��¨>Y���;��5���гcFD��El�FXr���B���l�n;{�	�<9|��)�,�.ূ�߅��!�PZ��@ţh�ae9 E�ӽn�7�/XoKW���l��d�~c^�h#���~��n��XaT�b{����pD>�KC�za�Q���B�+��MU�����fQV�5��Y���� >sIy��?tuV�p�Υ�.�{�.B�1gKn��y(ZD0�]��m_~j�y(��m�f��b|DA	���.U��һ���qy�{z��Ŏ�'y(x��n��~	��OE�� ��q[��n%M�4�a����ͪ�K� ��i9S�T1�5@ �Q�{� �B*t��^�Pۙ�a�c	lEDABB(/���j��BL���&o6tr9m����$�� 	�J��;��~�o^��#�X���l*��]|����u��8�ZaD�9Z]���^����e5;[V�MOx��Is���(G��
����췭7���%�w�>��l*��"5�&.`/(޷�.�M+_JP�$'�;�5^)a7���#���C�]LH�����.K���wcc�A�p��_;`љ�/�:"��<���_��_M���
T��E��-\Rz&3�M�(N�Ǣ���W�����o�(���LQ0B��$��}�������][}��w��SmS�A�,�DQT0zEd5��9�!������N���#`c�\SY^^������Bذ'x��+�C��2�q�@.���Ӌ��
�A�q����g��m^L��<t�2���}A�~�D���j޺^��RO���#EDПR#�������X����&:{灼\�h$bG��b�{���qj��GЌئ�S�%�WI��E����8 l���W�e�g���3n(F+�G��{ (�<1����+��S�ach����kM�ՎFԜF���eN#,�<��e����!�3Z|�w{�I^�'�8Jb�@4���6��m��x�y�>U�up��QN��Ѐ.IC�}Mu�I��[*�B+y�9	o����qeYLY����!\�M�y�I�À?[/�Q��?̂ȿ��7�f��V�r����%���Bö<Ň!����������󍄀{s�}�B�Y�0�1�4΂����
��+=�-5�qY�3�Y�@a���Ϛ�6����Q,D�P�K��^������caX� 7�LHc!�X������P_\B�^]������ZL�V����if2�ku���V���毌��1��	E���[�"�0<���6�P, ������^��_�X�q�/
g��M]�Ǽ��%L�M��{�p�k�H`JO�В�-���y�H���T
M�����ae�)sZ�tB$J����5���P3X]=n�����͔�1�
1�~~��h����y��"�lݼ�ۏ	(R*��g�*�U��� DasvKI�m훝_����e��T�M���$��bk!Z�W˽��|ʳ�ӹR�	��q��v������|���S��yw��,��O5L�()EL&n �q2�o;�yv�?&l�tBlK5�������|�c�۾�%���ŧ���\nip�E$6�2��A���X�H�[�'�I���HjS�A����]�׃o�����L�����\� Y��Ð��(�c;b�3ƕ��3
��H���*����s���#4���k;�E�F_�ϣ\#�/M��^؅e&M,���xV3:��u��KB.2\��e�ۿ�d �m�T�6D
�mf�4���"���B�����0_v�[!8����+�se��SA� Y�Vi�Mq�8�EM#r�#D���O�H*��8'��:��-@6 j�b��};�K�c�W�8�F��0(�@�D8�0����}��"3B�ߔ�%���i���~�＆
Bb� @k�֋��'��LΏ��?PY�N�H���'r^��	�.
I}��N��j�U}�C��K��s��բ����^��?�>M���[�ݯ�xR��H+�M�S�^�晙�Һ�`�������3��i �yf >eq� ՛�mj�V�z�
��U3Pp����슋W�vO�ǉ`�ݿ���5�7a�#G��Ú�18!��V�˙�0`8�˶��): �=�A��p�v�!	{�؅�|�P6��& S���A�P���%%�imM�R����d���Lt��
B���"�atL4
*Y#`����?I��ȉ'��}')�&A~�����?���F��#�6���%�ƃ��jy��%>����{g�������-�d��t���    ]F:,�l+.q��+�JÑ����.u���?1�wv�CUS+�U����B�Hɴ�ȋ2k4���S��e���˺��Y�)S���� �pљ���{�����)͘�TBO�۩R8�(ң�̹$���ۙ�qS�ir��)x0�Ǩ|F�SQö:�M�a��XNs�O���T�Y] ������8b�q��
>q;�m�x�X���j2���P/7
�NG|[���hb���qGJ�%E��E�ΐ~�B���e������\����S�!A��3:�"Nj�8��`�NՋ�,���I�Ф��u�b�$e��f��0�J��a�$8C�Ų���#�8sSr��� ����q%�}���~�ހ�$q�b�Hh2rc�,J������T�/F<0b��	��-�rj0�Y
�G���Xѻh�G��p
5 ��|�x���-&eP�5�rPI"��D�V7�Pp�W����>R�q�f`�r䱦�rq����p)�x��\J�!�Fh��Fn�'�\K��oW��/�Yd7�wc��Y�<Z���ߌ����. ��x�	�T ��.�@�"�n�͐q�Ж�ok�K���2�P���GAD�Y�`*f?w�n���Z����8�`�Z	�-����=�/����P�x�p�D�ar�+e��[Hm�褂_i-��+�B����?e%�b9#�9p�R�u=������o�p3)��&"0�vFAdq>��uS�:�vW�.z�WY��1�q�ӧ�Ռ:�.�ݽ� kB|��u�/>�va+��ǒI�@ڀ��d����\5�Y3�����uW�K3�@>L�bh�#^��������ZX4�L�@�Xe!�n:>U�{�`_�v�V���N�GY5 ��2��j&�Y�p�Q�t�eg�@��&j-���	�1ezp�L�i��b��w�Y7�o-OC*.2�y�Ȍ�w���o��Ĭg�9({J�GJ��Y��5͸��-uz���hD�珯�b��_��Z����`�).�����$��h"�)��h!���EΪ�1|�D��q��]HZ�J���[�'�r1Q�_��젙/��U��=Z�kh�$�H�"B@��j�qa�.�xvg_�n3�S��M´Lr�6����j+�W&��8r�yt�_]C��0.�h�  1yn>����*�hx��m�o�X��E iT���إ���qi�߸�-T,?-�^2W~! �$:�-$�}ia����~a��4��EbM@GE���~4�Q �]#dp��=!Ο�C�N�s"�ʲA�YВ��y+�Ϊ���iU=��p�9}�.q��JN
%t�ي�!	�Ed��6�|T�-7��X����5��*�.�����n�L�l����/�TzֶvH(]-k��Z��/0q�1��8$3�����B��א2�f��aZ�g�,dŐ-�e�f��g�grf��n�i���h��I˂�5��+�XA�L5��'���I5OcQ�٠�q��s+a��^�f�X�ï�h�WyGʶŀ�a�*��|�E޺O�U6�������ke�B�$�)K��1�6�62�ޚӒ:�2�؊��q>���j��m�R�e��\��y�?L�X&��!�v���ZY0�Fz�P���_hxnR�������j�rќ�!��aG�%����qw��]cI�[-�������ĒnG2SS��Յ�Ѐ4#Ǌ(�u������2oq����R�z(}�zÒju�zh+���i�W�YF��������ێ�4��B!�+U��?a��i��N��-��@��aC��i�92�8%4B��� 8
��3�pFp�~��\fb(|RO�W]����0�fQ��Z%9F|����'��ǭ}�)~<# �\@��MtjJ���	��i��ÝA����"7мg�PJvZaȝh�",pՙ���<������0��qc�:G���q���m)�g�n?׊�)�D]D���%C Q��z-��cI淮Z���ɽh͎I�Kq�>Ĩ�l#`�6662S*�T�R��s[�{���{YA?.�A ��}(I�
i�@�$�݆��~��B5��� ��X�<M�kY}���YbɅ�:K~���?t��;�d�P$�Bȭ�e~��d�������M��mJtKW�X�l�����_�!������6ur	-�L
���"\?rַ�晡����X%��"D�@�r9�
�>��ϕ}�&�2��R�W�<e2s$'�(Yү�Z9@�cpy~<��pz��&���]JM�y-Hl�i��\��wf@�d��
�(�a���tik�	u,]C�A9v�a�ۻ�*g�UꗢĎ��s|.���Y�U�2j�]�`�V������ӴȓB��랎��u�]Uk �e��Y%�z(����M1V�*Z��jϘW+X����7����w�Fe�h�ϵ���<6���o�6��+�Á�Hf�|���jpM�����󦛹�������~
E%���n6��5W�K��:�k��� d��Wg��j@#����^�3߱�v�@�L�JcROYQ8E���sS,�p�^�,_�S3��+�{�'7�mk��1����3��O6�(�w�F�c=����j4�&�D�O�c+J���%��@�>�O���|`�_f��]�#W(���0��	�l��p��7���<�+mS#^piW�}���k�⫘��N�Q�K�~�<	 �#j���T��\ʩ������!`N)<��3a����3��3���>:=�D+~c��$'9�K������& ۚ��J���!q���ū��.�b���k��C����ԕ9d�7����T8�k��}�ܾډBN����0Y�p�����vK;���:g.�_�}zZ���]:�����-���]�q{cz~l,
��(}��*IE�HT��8�a�|6v�D~j5V�.qF^�c˱RW�9pJ]t�S&G)�a;V%�������є}�n����d��f4͖g��L��Ys[��1c�L����S/N���ZvW���w��T�u%ax�UqKZl��d��,��i3)Ĩe!:-U���YI_ŕ�c�]�8��d��1���z���k�-�8�PIʙ@-Ƹ��m-���	y)��Ѳ�]'��TC-oݵ8]AsJ��J9�ΰE6��Ù�����5)��Ϯk�E���tE �'�ȋ[5�g��+M�2E_���A՞���B*���6\�8Fޝ�Y����\�2t����r��n��;��
�n�Cw����H{5���'��e�p���N^b�|�?,��lvͫU�b��\�����7D�I�Z�A�	�gQ����\�s�M%V�bCbU��������KdrF��v�{i�����\�B�0�YG�O�f�՛���X���e��X�[y^�[f��d +�uz�3�c����C�Ͱ�:�]�L7k����mr����ý�8��������p��E�;����i3ѝ��]��YLN�(�A��<��t�|���79�doJ�%y��VK+�c��:�\�)�<����eX
h���c�$\���W�Yկ�F��/_���K��>�e�2;�ϙD�n�Ro-0���Ԅ�~�l ;b����ff᰻^=�v�k�e"������`I��`�gC��[��]~E<?L�qn�TbEN��-��]�\��k=����b�?��R��y�CUR���GU��;���R��yL,����Y1Wt�ddWE���\�e�qIYJ�&.;!C;7+!8>��a���&ߤ�]�������M�Ϯ�È�K�2q:P�(Ơ��-��d)=��!$�4Jڥ	Nw$����ci�QC�W��v�ll4�O8uIbH)%�WH�KU���co�'���~��c��K�e����D˓��v/{�7�f*uG��"�1���s@g�5Φ�W�;ؚ��#��>�u*���W;|��3���+���ݕ:9��Ý(8��6D2c����-)�AR v闺]��_�.��{��󁭍�įt�0�N��b���u^��73�B����Kr\    �:]�����8E$Z������GՑ�
iͷc���6 l��̵5:�g<pG�(aW[�x�2���Vl�Z᪀�Nx2�%�n�p>Qۇ��xU����g�0ѣ��Rl$G����n8��ױ�Z�1���#>X��p�� Yy�0��jXOiDfw[�1���L�B%��$�ͫO{�.�m���Z�k&k	В��Xټ�]�Q(�e�\��?7��n�e����٩[玴��PKi�Q�����K��ױ?>�7nbh��}/�R�`Ș�e�k���p��/+�/�I#A���
S����c�[n|�Q�Θ`'	�A)Δ�w����|�g(Yg���B�|�������*p�fp`��S����N�<J#����m��'f���J�X�X9�1L.h�YO��*(����X�_w-B���X�:�#����gk�1I36�]Vk����׸iSlc�-Wa]UrN}����k�1O1�\g.]�ޱ�L�� ��*f.n�}5�j���aM�ќ���vI*�<v@Z�7�H�O�Ǝ��2���.�ꆳdVIr`M����m_u���9I��dڎ��}�y��2 �W�O9���ʝ�)+A�0/M�ETb��.p5�����<:]����B2�/J%�,�C���C��Ϲ3E��J���A���L��H�� �`7AL��N�]礅èIr��H@����v�a':��D ��bX���[�"
�J#���\���BI�zj���"v�j3������DҦp�6N�`����\3�1p��ȉ�rs)bx�P�,H[-I+֗-V�*��\c��"��8%G�5˺쁭�]�H�J��)�%�%���)c�$������CDꙫ���Nٹ"4Lf�BRïްOj(ɼՆ�j����e���Qj�F����BY��ȪN��K7��(RZ_: �e��|nt&p���ƿ�r�:����W�|�H�m�s�"�ۑɣ2�����P�\�=4s~4�L��C���I5����d�rQ�ra�,ją��E�{7-�`�t�9�ּv�	������O	;��4�~AW�������8" oX�nF�A�e�g��J|i:����Jڱ15�{+%�=s�\]�Na�{#%���!A�z��	*>;t~��%��K��1d".-��E �s/�4��D�;f5`�r��֖S!9lh��"�ϩg:��dK(��y��BXn?6
��ڬkT}��N�KH0Nc��cc��u�讟xl� 홾�u�E	��0z�a��N�k�྿U�P"����	�2�N�8[QJs��];��^�d�e�Xn�RJ�.��"�e�����*�~�d�]VFIF[*�)�G�,�LG����\b�:4	��?h;��.�!,k��:?� |·zS��J��+��8�icm�����-��qD�6�{h��8ZĄ&Gâ�o��t�+h	��G�V�~�넳�) .���:G�ĩ1��VG��}ܖ��'En�L�ǇIȤǁ%g'�Q�At���4uEi@)e�b�X���2x��*�.���~~�˶�Q��h>Z��^�-:������/O�Wr�P�8
����~��.+ަ~�\��XJ�X�(1.���-�g$}�i3s7�grn��7�� aRs*����wd�ǂ�K���͔7������9����h(��#ru�.1y:q�C�{�aJ[M�3�fj��@{^Z��2�&��K�&pB�t�8<��n�sQrU���8/�=*�Dch�����O��v&Ufr�p�N��-�k�b���ېUV��'�`�W�M��BZ7�f��ʸqz솦�u�$�����q�<�U6/̊<�B���X�n���ÀV[rû��g�$�+m�V�I�C���N�^�p��i�7�F�r=�E�znInٵ���4�|-Yŗ]���f��Pk6�oWa�7so��׵�N���b��ؽ�~�Ѱ^���w\�S/e��`'b��5݅Y��"q��: �C=	``V뺅#�i�8���$�ya�DXCC���_��#U���!i�;K�ݕ��$���)ML�T*���g�ݣ�(T�(�D���Ə�e�2�s� M��8�PpCģ ���Υ�5���%��Kɞr���ԣ�����d�1]�Vt
߹+�b��3�t��B8ԛE5�iR�8��X�f���$��������, <%MB�~z�S*%�BX1�Cj4e/����r�׶�_�$��(��C+٪!3z"�q%�ʡ�ۮ���(���c�B'��t��s�ucoK�X���TK����K�:��b�K쐉��_.����`Y.�py_B~n��6\5�
����������Xb�Y8�g�:�c��$Q/
��dҧBh������
V��K�6��g��9/f��=���}�&��$�t���Ymw빪Hⷫ%�!��,���11�CSp:����í%�,�0-�b���.k�Rv-���7C؇�&�
��$ӟa�*l�0��V��Q�zOn�%�,MK���:���TLg:���T\^(cچ-�e�(9����,ğ��	%n�%Pi�F��u��D�
����	�{���}�h�R���h��;]���9坉�w&2q�24�U���-��f��ѽH�G"�
2�L\�A�P�"��i��Z�v<�<sy��t8&W�nv�!�]@�0	�eN/Vv;Q�o>݄K�ԩ��?��gN֬��h+}����cu:�Q3�j�(���_��(�\����UMe�L��QJ�@��.���q�ŝ]����8���ҳQT����E����T	i���R����~��FY��ɵ�Q���9Dg��3�<I2�|+�(��}�3|�I��_�h�u΄��C�̙�UY*�3��T�j���T6�+"��r������;���t�N�-���9e��u�A�&e������cA&=�Sݺ�W����Db�w�s�I�%�JJ�h�ʏ����b�+<L�	P���h���L\�DAg��Xu�	y=�i-�&�75l>Q~.��R�-�U�,�U�j��m,tq771&Q������g�=a�����
ի�f��M�� �$��F��C6�_e���[r7�*��>t�k�j�=ʂ��-,����鉝c�sG�=��~X�U��P�{I�ל2�V���9;����)$�����tQC��a�I��aG�a���͎�䎝��		�N��c��/h�e \��!F�۾�m&2e<��F2�<���(�};���U�ٹ~~�˕\�|j���:�G�q��w�2�n�$�zZ��Լ�$wi	É��v�{GX���(t�)��`�g�+91\�M�����v�����@C~Q��};#����dC��e�p̤��~������N;����Ț21����E�3D��׻%Di讼j�#v9���d�z��\r��S+���L���;H�P��qF����*�R�*��/�p����b}�Q�T�e��lq��q�Ɓѵ�n�o�[W�c zJZC�OC�o�D�{���i��%��x�3��̹�#UNI�6�3Ș�öϴ���@C(�09��_�4Ţ�b�d���)�Q9�pA��)�7?�r����ǵ��>A��i�����4%A�?$u:�D'B�a"R)����c�|�f+V����a�5��SV�t@8�i`�2r�Z80���T�)d�D^(�K%��.Ɉ�zy���0^3�WLX��lH�0�&�uW�#��H�֯zەSS�e�ʄ�H� `��l�|u3Ifr�D>Kɼ���c���\�Cv����^����d�8+�W$��������Vf���n��A3��&��Ã�az�DxO~�Κ���;�$�3��iQ �G���R[���aՍd��h��t��I޻(�#�謑���(�:�����Y:�:�����.`�ط�r4�e�$t>��^�
π����B�%R��O@���R7ǝK^q
�����r+a�D"6=��WЌ��W�VͥBt����p+Bp�gn�5�x��V^d&�l�l�(�G�fc�\���g�N&����_�S��	��I�x4�@wy:�/X!�ON��4y 
  �yRX=�l�w�S�4��l��1qqj�Y���u��'z�����wu˗��?�(ۗHOr$C괦e)�yz���u��.?˱!Qn��ޥ��bU}��-⨉\ڭ�<)�<L���O���^Δ���IY>�,'5��Њ�@�%�47o��H�d,[�{!�8>�\fP�)�\/��������s����_Q�/7����q��ǤJ��a��\Q2Տf"��0I���BA�<�>Dlm=<�8�̈���T�ˈ�vR�� ��*dp� �*T����a�1?L_4��m@���g��L�����4�8�ANZ&�=t��q��q���ө���5g�)c��ٸ|�-���	ٶ��Lדk�k{ջ�&��TH��űwi�$i�v�v��$b�m\zі���0�KG������Q�70P���w��$r���p�y���@+,?�}�#�{!�\I�dU�q=yI�P���aN�޷c��G̆2H_�c9bvk�H:�jsg�q0<�Ts�q��$/�5.���k9���h_%>��(u�+p�t)a���@kb�<6ڑ}�<^
�c8�"^$���t�	t��_�\;tN�_�]��;�8��t�q^��R�5>)��M�Z>2��X�r9���Ei�i�Sp\�N[��Q�s�DK�a��QyEx�˨[��64:�+�����f[�>��Ψ��ĞGEeɏ٠����*31�G�T�2��Lm���Շ�tT�c��e���+4�Ƌ#4��Of�`䂶�_S�xV}�Z��*�� /Ma�Dd�!E�.-��J�x�Z��W7;3���sS��&EY9��M�l��k)M9�G���ls�ߤpx:8�T$���vk�2�X�����>zȵ�L��7J�AJ�R*��q�����s�P�#H�@����UP�vB��}��k��8���y5�R�S�U�'�LĔRA��҆��nD
�Fp���N�A:c8�]�NuT�Y�ʴ�C�xֲ�t6 ���\8/��"�ZM�,�ڎ��CfȔ~�Q�Ha��\�*}	��6B�.�.���]�Mn+3���Wm[y�����'�����lar���;�춆��S�$�7���>�yY&�S�z܈ �5�j2�5�œ�bx�.b��&��-��D���̆䮇�t7Z�V �K5�����Img�l�z�t�J�e\
xV���C��B՛� 3�`Mj�rzp�)0m�� �:��GP~�^��m$N��(M��"��-I�Y=�қ��	W�=>)�|���<>9���P=�,�Ѵ�nEW<S81d��in9�8�G:��7�$�{K�q�\� �@�1yy�#N}A}���Az�_S�����=�!��y	�|�ƇRF%C��<�Z¥�N�
��tM2���a)h-�K�^�t��p��xל�.M2��$��j�fҁ��!?৯�{)�HGZ^:Ԃ.彞�������*�+G��f�T�<�J;[��x��n����DK�Qn/�|^?�ewku,��.�[��Pz�O�9s�tu/$�s9@���A;��i��'�R|1Gś̽��DC��8��ueg�'>NûL&�J�k,U6�%d����_�2�JB��E.�W�8 ����V�l2����IO�8ݓ�m 1�т���<7���l�R�����|3����o7r�\����yFv�1�t �\�lʼ+�#�+8�/�!��n���C���I�D_�Ύ";����k��q4���	)v-y,�+���A��aĘ>~����^���8w�}�%�L�@u4�T�J:`@,�/9m�.��Ω�DC��&�� �s�]��+����S�˅̐���\�/12���{���R+��&F��ܽ?3��8������j&���?�ӧ#���'GEh���c�26�=�Ù�M%�b�e�8�>y�Ky���Y�Rͧ���yE���(ѕt�W�x��R�����-���!*�B�c��'{��b��=�ԽYǷ�9?��@`a�]S��V���b6˛����Ή����&)'����L3��T�͇Yk������Bϡ�ؗ�������Ԗhgv#��^���3������2��m$��hӾ���L�ʺx�8�.gcl)�	����5֕��i��h2.^�K 2�����+·/�J�70Ͳ𧏘���� ���⠆՞+����DQ��0�C&(��/ �͡�vp!�Ea.J˵����N��^C� \��=wĉ����InY�	�-KF�;���?����	�Gg�^ "�|��(k�Ë��F������tݘ˷�>�eM�!>2Q���_:�}RS}�o�x�+/Ǉ�c:����s�t�Z�I�d^�Q����l��0�D]���H�^W�L�IE���g�Z�������8�S\a�i_�|��z[�'�FM9t+�q�G��qT�8�:lN:k�s'�WK&�ae����!᪸�#Gf'[�ߛ�d'��)a��I�Z��n������j�[r�5��2 �TG�C^���D����O�l�7��酳i8�Pe��ݭ�&�(�z�}��q �_��g�����7��      T   \   x�3�0�bÅ/��}a'�煅v\��;��9/,�8(�3�0�����S�­@��6�/6�%�8/L������� �=�      X   �   x�E�;�@F����p.� K2��BH��d$���(���RQ��0���L��i�b�֯Z���u(Ƞa���k���Do���:tC�$sB�$��en�)A3�}
t�(\���_Ob�s�&�hФ���f�Z�����j+�����)�      R      x������ � �      J   =   x�3�0�{.츰����.6\�p��¾�\F��\�
��
T���V�P� ���      N   )   x�3��qtqT���bӅ6]l����~ �}��+F��� ��      P   |   x�m���@D��*�$cӍ�� Y"!r����LG�#"p6�����F�X*x����Β��� �=b_�z�)~�����?�Y�Q��C�8 0g-O�g��PO��9���31�h�o�      L   �  x�=�͎�@����D���V�*)+�ri�6�x<c���O��3�Q��U�s�ƳT�X�2�H[!��;{��x)w�?����C�.�����(ɿ���EC]��c�+e�W��p�%��8d\���(��9�Z��h�}R��	��*�w.Rb˪W��l��;r7�O8��k2��I%V�$&e�R[�D��7�	[��Ή�*�C�4��؊�e\���R��p95L�f��hq}3n�Z���O�;4T���r~��bo�?�U�kg�,��e�x�9��u�d	
J���\�Δ����&�r��c}�А�؄�s?�����0���Ї����q֘�9��Ji wc?��|I-�uVի�����1Q]�Џc�~<ˊՏ��ɟ��������ק�l���     